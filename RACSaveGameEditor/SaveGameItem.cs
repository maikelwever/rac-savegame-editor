using System;
using System.Text.RegularExpressions;
using Gtk;

namespace RACSaveGameEditor {
    public abstract class SaveGameItem {
        public string name;
        private int position;

        public SaveGameItem(string name, int position) {
            this.name = name;
            this.position = position;
        }

        public abstract void ReadValue(SaveGameContainer container);
        public abstract void WriteValue(SaveGameContainer container);
        public abstract Widget CreateEditWidget();

        public class Integer : SaveGameItem
        {
            protected int value = 0;

            public Integer(string name, int position) : base(name, position)
            {
            }

            public override Widget CreateEditWidget()
            {
                var widget = new Entry();
                widget.InputPurpose = InputPurpose.Digits;
                widget.Text = value.ToString();
                widget.Changed += (sender, args) => {
                    string newText = Regex.Replace(widget.Text, "[^0-9]", "");

                    if (newText.Length == 0)
                    {
                        value = 0;
                    }
                    else
                    {
                        try
                        {
                            value = Convert.ToInt32(newText);
                            widget.Text = newText;
                        }
                        catch (OverflowException)
                        {
                            newText = newText.Substring(0, newText.Length - 1);
                        }
                    }

                    widget.Text = newText;
                };
                return widget;
            }

            public override void ReadValue(SaveGameContainer container)
            {
                value = container.ReadInt(position);
            }

            public override void WriteValue(SaveGameContainer container)
            {
                container.WriteInt(position, value);
            }
        }

        public class Byte : SaveGameItem
        {
            protected byte value;

            public Byte(string name, int position) : base(name, position)
            {
            }

            public override Widget CreateEditWidget()
            {
                var widget = new Entry();
                widget.InputPurpose = InputPurpose.Digits;
                widget.Text = value.ToString();
                widget.Changed += (sender, args) => {
                    try {
                        string newText = Regex.Replace(widget.Text, "[^0-9]", "");
                        value = Convert.ToByte(newText);
                        widget.Text = newText;
                    } catch (OverflowException) {
                        widget.Text = widget.Text.Substring(0, widget.Text.Length - 1);
                    }
                };
                return widget;
            }

            public override void ReadValue(SaveGameContainer container)
            {
                value = container.ReadByte(position);
            }

            public override void WriteValue(SaveGameContainer container)
            {
                container.WriteByte(position, value);
            }
        }

        public class RangedInteger : Integer
        {
            protected int min;
            protected int max;

            public RangedInteger(string name, int position, int min, int max) : base(name, position)
            {
                this.min = min;
                this.max = max;
            }

            public override Widget CreateEditWidget()
            {
                var widget = new HScale((double) min, (double) max, 1.0);
                widget.Value = (double) value;
                widget.ChangeValue += (sender, args) => {
                    value = (int) widget.Value;
                };
                return widget;
            }
        }

        public class RangedShort : Byte
        {
            protected int min;
            protected int max;

            public RangedShort(string name, int position, int max) : base(name, position)
            {
                this.min = 0;
                this.max = max;
            }

            public RangedShort(string name, int position, int min, int max) : base(name, position)
            {
                this.min = min;
                this.max = max;
            }

            public override Widget CreateEditWidget()
            {
                var widget = new HScale((double) min, (double) max, 1.0);
                widget.Value = (double) value;
                widget.ChangeValue += (sender, args) => {
                    value = (byte) widget.Value;
                };
                return widget;
            }
        }

        public class Boolean : Byte
        {
            public Boolean(string name, int position) : base(name, position)
            {
            }

            public override Widget CreateEditWidget()
            {
                /*var widget = new Switch {Active = value > 0};
                widget.ButtonReleaseEvent += (sender, args) => {
                    value = (byte) (widget.Active ? 1 : 0);
                };*/
                
                var widget = new CheckButton {Active = value > 0};
                widget.Clicked += (sender, args) =>
                {
                    value = (byte) (widget.Active ? 1 : 0);
                };

                var box = new Box(Orientation.Horizontal, 10) {CenterWidget = widget};
                return box;
            }
        }

    }
}