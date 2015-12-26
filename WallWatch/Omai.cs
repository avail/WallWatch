using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WallWatch
{
    public class TextBoxStreamWriter : TextWriter
    {
        TextBox _output = null;
        StringBuilder _sb = new StringBuilder();

        public TextBoxStreamWriter(TextBox output)
        {
            _output = output;
        }

        public override void Flush()
        {
            base.Flush();
            _output.AppendText(_sb.ToString());
            _sb.Clear();
        }

        public override void Write(char value)
        {
            base.Write(value);
            //_output.AppendText(value.ToString()); // When character data is written, append it to the text box.
            _sb.Append(value.ToString());
        }

        public override void WriteLine(string value)
        {
            //base.WriteLine(value);
            _output.AppendText(value.ToString() + "\n"); // When character data is written, append it to the text box.
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}
