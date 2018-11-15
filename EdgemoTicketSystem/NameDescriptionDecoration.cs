using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EdgemoTicketSystem
{
    class NameDescriptionDecoration : BrightIdeasSoftware.AbstractDecoration
    {
        public string Title;
        public string Description;

        public Font TitleFont = new Font("Segoe UI", 9, FontStyle.Bold);
        public Color TitleColor = Color.FromArgb(255, 0, 0, 0);
        public Font DescriptionFont = new Font("Segoe UI", 9);
        public Color DescriptionColor = Color.FromArgb(255, 105, 105, 105);
        public Size CellPadding = new Size(2, 2);

        public override void Draw(BrightIdeasSoftware.ObjectListView olv, Graphics g, Rectangle r)
        {
            Rectangle cellBounds = this.CellBounds;
            CellBounds.Inflate(-this.CellPadding.Width, -this.CellPadding.Width); //Does what?
            Rectangle textBounds = cellBounds;

            // Draw title
            using (StringFormat format = new StringFormat(StringFormatFlags.NoWrap))
            {
                format.Trimming = StringTrimming.EllipsisCharacter; //Text is trimmed to the nearest character and ... appended
                format.Alignment = StringAlignment.Near;
                format.LineAlignment = StringAlignment.Near;
                using (SolidBrush b = new SolidBrush(this.TitleColor))
                {
                    g.DrawString(this.Title, this.TitleFont, b, textBounds, format);
                }
                // Draw description
                SizeF size = g.MeasureString(this.Title, this.TitleFont, (int)textBounds.Width, format);
                textBounds.Y += (int)size.Height;
                textBounds.Height -= (int)size.Height;
            }
            
            // Draw description
            using (StringFormat format2 = new StringFormat())
            {
                format2.Trimming = StringTrimming.EllipsisCharacter;
                using (SolidBrush b = new SolidBrush(this.DescriptionColor))
                {
                    g.DrawString(this.Description, this.DescriptionFont, b, textBounds, format2);
                }
            }
        }
    }
}
