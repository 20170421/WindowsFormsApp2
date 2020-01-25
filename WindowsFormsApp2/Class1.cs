using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class GroupBoxMaker
    {
        public GroupBox NewGroupBox(String name)
        {
            GroupBox newGroupbox = new GroupBox();
            newGroupbox.Name = name;
            return newGroupbox;
        }

        public PictureBox NewPictureBox()
        {
            PictureBox NewPictureBox = new PictureBox();
            return NewPictureBox;
        }

    }
}
