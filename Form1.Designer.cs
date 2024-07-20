namespace ivan_asked_me_for_help
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.fullname = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.fullnamebox = new System.Windows.Forms.TextBox();
            this.colorbox = new System.Windows.Forms.TextBox();
            this.modelbox = new System.Windows.Forms.TextBox();
            this.numbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deletebutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 251);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelbutton);
            this.groupBox1.Controls.Add(this.savebutton);
            this.groupBox1.Controls.Add(this.fullname);
            this.groupBox1.Controls.Add(this.color);
            this.groupBox1.Controls.Add(this.model);
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Controls.Add(this.fullnamebox);
            this.groupBox1.Controls.Add(this.colorbox);
            this.groupBox1.Controls.Add(this.modelbox);
            this.groupBox1.Controls.Add(this.numbox);
            this.groupBox1.Location = new System.Drawing.Point(214, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 234);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            this.groupBox1.Visible = false;
            this.groupBox1.VisibleChanged += new System.EventHandler(this.groupBox1_VisibleChanged);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(140, 205);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(100, 23);
            this.cancelbutton.TabIndex = 9;
            this.cancelbutton.Text = "отмена изменений";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(21, 205);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "сохранить";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // fullname
            // 
            this.fullname.AutoSize = true;
            this.fullname.Location = new System.Drawing.Point(18, 175);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(91, 13);
            this.fullname.TabIndex = 7;
            this.fullname.Text = "ФИО владельца";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(18, 129);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(30, 13);
            this.color.TabIndex = 6;
            this.color.Text = "цвет";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(18, 83);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(45, 13);
            this.model.TabIndex = 5;
            this.model.Text = "модель";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(18, 38);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(56, 13);
            this.number.TabIndex = 4;
            this.number.Text = "госномер";
            // 
            // fullnamebox
            // 
            this.fullnamebox.Location = new System.Drawing.Point(140, 168);
            this.fullnamebox.Name = "fullnamebox";
            this.fullnamebox.Size = new System.Drawing.Size(100, 20);
            this.fullnamebox.TabIndex = 3;
            // 
            // colorbox
            // 
            this.colorbox.Location = new System.Drawing.Point(140, 126);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(100, 20);
            this.colorbox.TabIndex = 2;
            // 
            // modelbox
            // 
            this.modelbox.Location = new System.Drawing.Point(140, 83);
            this.modelbox.Name = "modelbox";
            this.modelbox.Size = new System.Drawing.Size(100, 20);
            this.modelbox.TabIndex = 1;
            // 
            // numbox
            // 
            this.numbox.Location = new System.Drawing.Point(140, 32);
            this.numbox.Name = "numbox";
            this.numbox.Size = new System.Drawing.Size(100, 20);
            this.numbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список номеров";
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(25, 323);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 4;
            this.deletebutton.Text = "Удалить";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 395);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label fullname;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox fullnamebox;
        private System.Windows.Forms.TextBox colorbox;
        private System.Windows.Forms.TextBox modelbox;
        private System.Windows.Forms.TextBox numbox;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletebutton;
    }
}

