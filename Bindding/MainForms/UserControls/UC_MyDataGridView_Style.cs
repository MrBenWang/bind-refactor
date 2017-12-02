using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bindding.MainForms.UserControls
{
    public partial class UC_MyDataGridView_Style : UserControl
    {
        public UC_MyDataGridView_Style()
        {
            InitializeComponent();
            GDV_Style();
        }

        public DataGridView MyDataGridView
        {
            get
            {
                return this.dgv_style;
            }
        }

        private void GDV_Style()
        {
            #region DataGridVeiw Style

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_style.AllowUserToAddRows = false;
            this.dgv_style.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgv_style.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_style.BackgroundColor = System.Drawing.Color.White;
            this.dgv_style.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_style.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_style.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_style.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_style.EnableHeadersVisualStyles = false;
            this.dgv_style.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_style.ReadOnly = true;
            this.dgv_style.RowHeadersVisible = false; //建议改为true；为了以后显示序号。
            this.dgv_style.RowTemplate.Height = 23;
            this.dgv_style.RowTemplate.ReadOnly = true;

            #endregion DataGridVeiw Style
        }

        private void dgv_style_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgv_style.ClearSelection();
        }
    }
}