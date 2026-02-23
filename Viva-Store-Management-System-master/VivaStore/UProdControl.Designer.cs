
namespace VivaStore
{
    partial class UProdControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.product_icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrName = new System.Windows.Forms.Label();
            this.ProLabel1 = new System.Windows.Forms.Label();
            this.ProPrice1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProPrice = new System.Windows.Forms.Label();
            this.CurrPro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // product_icon
            // 
            this.product_icon.Location = new System.Drawing.Point(24, 20);
            this.product_icon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.product_icon.Name = "product_icon";
            this.product_icon.Size = new System.Drawing.Size(164, 129);
            this.product_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_icon.TabIndex = 104;
            this.product_icon.TabStop = false;
            this.product_icon.MouseEnter += new System.EventHandler(this.Cols_MouseEnter);
            this.product_icon.MouseLeave += new System.EventHandler(this.Cols_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrName);
            this.panel1.Location = new System.Drawing.Point(290, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 48);
            this.panel1.TabIndex = 105;
            // 
            // PrName
            // 
            this.PrName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrName.ForeColor = System.Drawing.Color.White;
            this.PrName.Location = new System.Drawing.Point(0, 0);
            this.PrName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrName.MinimumSize = new System.Drawing.Size(176, 48);
            this.PrName.Name = "PrName";
            this.PrName.Size = new System.Drawing.Size(242, 48);
            this.PrName.TabIndex = 100;
            this.PrName.Text = "Product name";
            this.PrName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrName.MouseEnter += new System.EventHandler(this.Cols_MouseEnter);
            this.PrName.MouseLeave += new System.EventHandler(this.Cols_MouseLeave);
            // 
            // ProLabel1
            // 
            this.ProLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProLabel1.ForeColor = System.Drawing.Color.White;
            this.ProLabel1.Location = new System.Drawing.Point(196, 11);
            this.ProLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProLabel1.Name = "ProLabel1";
            this.ProLabel1.Size = new System.Drawing.Size(94, 48);
            this.ProLabel1.TabIndex = 106;
            this.ProLabel1.Text = "Product:";
            this.ProLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProLabel1.MouseEnter += new System.EventHandler(this.Cols_MouseEnter);
            this.ProLabel1.MouseLeave += new System.EventHandler(this.Cols_MouseLeave);
            // 
            // ProPrice1
            // 
            this.ProPrice1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProPrice1.ForeColor = System.Drawing.Color.White;
            this.ProPrice1.Location = new System.Drawing.Point(196, 63);
            this.ProPrice1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProPrice1.Name = "ProPrice1";
            this.ProPrice1.Size = new System.Drawing.Size(70, 48);
            this.ProPrice1.TabIndex = 108;
            this.ProPrice1.Text = "Price:";
            this.ProPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProPrice1.MouseEnter += new System.EventHandler(this.Cols_MouseEnter);
            this.ProPrice1.MouseLeave += new System.EventHandler(this.Cols_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProPrice);
            this.panel2.Location = new System.Drawing.Point(264, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 48);
            this.panel2.TabIndex = 107;
            // 
            // ProPrice
            // 
            this.ProPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProPrice.ForeColor = System.Drawing.Color.White;
            this.ProPrice.Location = new System.Drawing.Point(0, 0);
            this.ProPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProPrice.MinimumSize = new System.Drawing.Size(176, 48);
            this.ProPrice.Name = "ProPrice";
            this.ProPrice.Size = new System.Drawing.Size(176, 48);
            this.ProPrice.TabIndex = 100;
            this.ProPrice.Text = "Price";
            this.ProPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProPrice.MouseEnter += new System.EventHandler(this.Cols_MouseEnter);
            this.ProPrice.MouseLeave += new System.EventHandler(this.Cols_MouseLeave);
            // 
            // CurrPro
            // 
            this.CurrPro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrPro.ForeColor = System.Drawing.Color.White;
            this.CurrPro.Location = new System.Drawing.Point(196, 111);
            this.CurrPro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrPro.Name = "CurrPro";
            this.CurrPro.Size = new System.Drawing.Size(143, 48);
            this.CurrPro.TabIndex = 109;
            this.CurrPro.Text = "Currency:Rs";
            this.CurrPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrPro.MouseEnter += new System.EventHandler(this.Cols_MouseEnter);
            this.CurrPro.MouseLeave += new System.EventHandler(this.Cols_MouseLeave);
            // 
            // UProdControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.CurrPro);
            this.Controls.Add(this.ProPrice1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ProLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.product_icon);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UProdControl";
            this.Size = new System.Drawing.Size(558, 171);
            this.Load += new System.EventHandler(this.UProdControl_Load);
            this.MouseEnter += new System.EventHandler(this.Cols_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Cols_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.product_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox product_icon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PrName;
        private System.Windows.Forms.Label CurrPro;
        private System.Windows.Forms.Label ProPrice1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ProPrice;
        private System.Windows.Forms.Label ProLabel1;
    }
}
