using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Rendering;
using DevExpress.Utils.DirectXPaint;
using FastReport.Utils;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Sistema_Integrado.SeekClass
{

    public partial class SymbolSelectorControl : UserControl
    {
        private const int UIntSize = 4;
        private static readonly IntPtr HGDI_ERROR = new IntPtr(-1);


        public SymbolSelectorControl()
        {
            InitializeComponent();
        }


        private void SetColors(ItemPanel itemPanel)
        {
            ElementStyle styleClass = (ElementStyle)((Office2007Renderer)GlobalManager.Renderer).ColorTable.StyleClasses[(object)ElementStyleClassKeys.ItemPanelKey];
            itemPanel.BackgroundStyle.BackColor = styleClass.BackColor;
            itemPanel.BackgroundStyle.BackColor2 = styleClass.BackColor2;
        }

        [DllImport("gdi32.dll")]
        private static extern uint GetFontUnicodeRanges(IntPtr hdc, IntPtr lpgs);

        [DllImport("gdi32.dll")]
        private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        private void symbol_Click(object sender, EventArgs e)
        {
            if ((sender as ItemPanel).SelectedItem != null)
            {
                symbolBox.Symbol = (sender as ItemPanel).SelectedItem.ToString();
                diminuiExpandeObjeto();
            }
        }

        private void symbolBox1_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count <= 0)
            {                
                string str = (string)null;
                System.Windows.Forms.TabControl tabControl = new System.Windows.Forms.TabControl();
                tabControl.TabPages.Add("Símbolos");
                tabControl.Height = 200;
                ItemPanel itemPanel1 = new ItemPanel();
                itemPanel1.Font = Symbols.FontAwesome;
                itemPanel1.MultiLine = true;
                itemPanel1.AutoScroll = true;
                itemPanel1.LayoutOrientation = eOrientation.Horizontal;
                itemPanel1.Dock = DockStyle.Fill;
                itemPanel1.SelectedIndexChanged += symbol_Click;
                tabControl.TabPages[0].Controls.Add((Control)itemPanel1);
                this.SetColors(itemPanel1);
                for (int index = 61440; index <= 61952; ++index)
                {
                    ButtonItem buttonItem = new ButtonItem();
                    buttonItem.AutoCheckOnClick = true;
                    buttonItem.OptionGroup = "sym";
                    buttonItem.Text = char.ConvertFromUtf32(index);
                    buttonItem.Tooltip = string.Format("{0:x}", (object)index);
                    buttonItem.Tag = (object)index;
                    if (buttonItem.Text == str)
                        buttonItem.Checked = true;
                    itemPanel1.Items.Add((BaseItem)buttonItem);
                }

                eSymbolSet eSymbolSet = eSymbolSet.Awesome;
                string name = this.Name;
                PropertyInfo property = this.GetType().GetProperty(name + "Set", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (property != null && property.PropertyType == typeof(eSymbolSet))
                    eSymbolSet = (eSymbolSet)property.GetValue(this, (object[])null);
                tabControl.SelectedIndex = eSymbolSet != eSymbolSet.Material ? 0 : 1;
                tabControl.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add((Control)tabControl);
                panel1.Visible = true;
                panel1.Size = new Size(230, 160);
                this.Size = new Size(240, 200);
                this.BringToFront();
            }
            else
            {
                diminuiExpandeObjeto();
            }
        }

        private void diminuiExpandeObjeto()
        {
            try
            {
                panel1.Visible = !panel1.Visible;
                if (panel1.Visible)
                {
                    this.BringToFront();
                    this.Size = new Size(240, 200);
                }
                else
                {
                    this.Size = new Size(40, 35);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
