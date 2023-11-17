namespace Lesson_10_11
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxCategory = new ComboBox();
            listBoxProducts = new ListBox();
            listBoxCart = new ListBox();
            AddCartBtn = new Button();
            textBoxTotalPay = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxCount = new TextBox();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(377, 12);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(427, 33);
            comboBoxCategory.TabIndex = 0;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // listBoxProducts
            // 
            listBoxProducts.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.HorizontalScrollbar = true;
            listBoxProducts.ItemHeight = 25;
            listBoxProducts.Location = new Point(0, 8);
            listBoxProducts.Margin = new Padding(10, 3, 3, 3);
            listBoxProducts.MultiColumn = true;
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.ScrollAlwaysVisible = true;
            listBoxProducts.Size = new Size(326, 479);
            listBoxProducts.TabIndex = 1;
            // 
            // listBoxCart
            // 
            listBoxCart.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listBoxCart.FormattingEnabled = true;
            listBoxCart.ItemHeight = 30;
            listBoxCart.Location = new Point(332, 63);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(496, 424);
            listBoxCart.TabIndex = 2;
            // 
            // AddCartBtn
            // 
            AddCartBtn.BackColor = SystemColors.WindowFrame;
            AddCartBtn.ForeColor = SystemColors.ControlLightLight;
            AddCartBtn.Location = new Point(88, 514);
            AddCartBtn.Name = "AddCartBtn";
            AddCartBtn.Size = new Size(118, 55);
            AddCartBtn.TabIndex = 3;
            AddCartBtn.Text = "Купить";
            AddCartBtn.UseVisualStyleBackColor = false;
            AddCartBtn.Click += AddCartBtn_Click;
            // 
            // textBoxTotalPay
            // 
            textBoxTotalPay.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTotalPay.Location = new Point(377, 536);
            textBoxTotalPay.Name = "textBoxTotalPay";
            textBoxTotalPay.ReadOnly = true;
            textBoxTotalPay.Size = new Size(224, 33);
            textBoxTotalPay.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(377, 508);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 5;
            label1.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(623, 508);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 6;
            label2.Text = "Count";
            // 
            // textBoxCount
            // 
            textBoxCount.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCount.Location = new Point(623, 536);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.ReadOnly = true;
            textBoxCount.Size = new Size(181, 33);
            textBoxCount.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 600);
            Controls.Add(textBoxCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTotalPay);
            Controls.Add(AddCartBtn);
            Controls.Add(listBoxCart);
            Controls.Add(listBoxProducts);
            Controls.Add(comboBoxCategory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCategory;
        private ListBox listBoxProducts;
        private ListBox listBoxCart;
        private Button AddCartBtn;
        private TextBox textBoxTotalPay;
        private Label label1;
        private Label label2;
        private TextBox textBoxCount;
    }
}