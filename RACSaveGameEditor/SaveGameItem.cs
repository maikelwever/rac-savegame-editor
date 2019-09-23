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

        public abstract void ReadValue(byte[] data);
        public abstract void WriteValue(ref byte[] data);
        public abstract Widget CreateEditWidget();

        public static int ReadInt(byte[] data, int offset, int length = 4)
        {
            int result = 0;
            for (int i = 0; i < length; i++)
            {
                result |= data[offset + i] << ((length - i - 1) * 8);
            }

            return result;
        }

        public static void WriteInt(ref byte[] data, int offset, int input, int length = 4)
        {
            byte[] byt = BitConverter.GetBytes(input);
            for (int i = 0; i < length; i++)
            {
                data[offset + i] = byt[length - i - 1];
            }
        }

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

            public override void ReadValue(byte[] data)
            {
                value = ReadInt(data, position);
            }

            public override void WriteValue(ref byte[] data)
            {
                WriteInt(ref data, position, value);
            }
        }

        public class Short : SaveGameItem
        {
            protected byte value;

            public Short(string name, int position) : base(name, position)
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

            public override void ReadValue(byte[] data)
            {
                value = data[position];
            }

            public override void WriteValue(ref byte[] data)
            {
                data[position] = value;
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

        public class RangedShort : Short
        {
            protected int min;
            protected int max;

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

        public class Boolean : Short
        {
            public Boolean(string name, int position) : base(name, position)
            {
            }

            public override Widget CreateEditWidget()
            {
                var widget = new Switch();
                widget.Active = value > 0;
                widget.ButtonReleaseEvent += (sender, args) => {
                    value = (byte) (widget.Active ? 1 : 0);
                };
                var box = new Box(Orientation.Horizontal, 10);
                box.CenterWidget = widget;
                return box;
            }
        }

    }
}