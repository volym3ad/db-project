namespace DataBaseMySQL
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testDataSet = new DataBaseMySQL.testDataSet();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamTableAdapter = new DataBaseMySQL.testDataSetTableAdapters.teamTableAdapter();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titlesbutton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.avgtitlesbutton = new System.Windows.Forms.RadioButton();
            this.join1 = new System.Windows.Forms.RadioButton();
            this.joinorder = new System.Windows.Forms.RadioButton();
            this.countbutton = new System.Windows.Forms.RadioButton();
            this.experience = new System.Windows.Forms.RadioButton();
            this.updatebutton = new System.Windows.Forms.RadioButton();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.alteradd = new System.Windows.Forms.RadioButton();
            this.dropcolumn = new System.Windows.Forms.RadioButton();
            this.view = new System.Windows.Forms.RadioButton();
            this.delete = new System.Windows.Forms.RadioButton();
            this.dump = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "team";
            this.teamBindingSource.DataSource = this.testDataSet;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(53, 45);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 22);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Team";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.EnabledChanged += new System.EventHandler(this.radioButton1_EnabledChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(53, 73);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 22);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Statistics";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(53, 101);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 22);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Players";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tables:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "RGR_made_by_Voloshyn";
            // 
            // titlesbutton
            // 
            this.titlesbutton.AutoSize = true;
            this.titlesbutton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titlesbutton.Location = new System.Drawing.Point(186, 45);
            this.titlesbutton.Name = "titlesbutton";
            this.titlesbutton.Size = new System.Drawing.Size(80, 22);
            this.titlesbutton.TabIndex = 0;
            this.titlesbutton.TabStop = true;
            this.titlesbutton.Text = "Titles > 0";
            this.titlesbutton.UseVisualStyleBackColor = true;
            this.titlesbutton.CheckedChanged += new System.EventHandler(this.titlesbutton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(183, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Commands:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(749, 481);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 151;
            this.lineShape1.X2 = 151;
            this.lineShape1.Y1 = 17;
            this.lineShape1.Y2 = 132;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 53;
            this.lineShape2.X2 = 697;
            this.lineShape2.Y1 = 132;
            this.lineShape2.Y2 = 132;
            // 
            // avgtitlesbutton
            // 
            this.avgtitlesbutton.AutoSize = true;
            this.avgtitlesbutton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgtitlesbutton.Location = new System.Drawing.Point(186, 73);
            this.avgtitlesbutton.Name = "avgtitlesbutton";
            this.avgtitlesbutton.Size = new System.Drawing.Size(131, 22);
            this.avgtitlesbutton.TabIndex = 8;
            this.avgtitlesbutton.TabStop = true;
            this.avgtitlesbutton.Text = "avgAmountTitles";
            this.avgtitlesbutton.UseVisualStyleBackColor = true;
            this.avgtitlesbutton.CheckedChanged += new System.EventHandler(this.avgtitlesbutton_CheckedChanged);
            // 
            // join1
            // 
            this.join1.AutoSize = true;
            this.join1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.join1.Location = new System.Drawing.Point(186, 101);
            this.join1.Name = "join1";
            this.join1.Size = new System.Drawing.Size(80, 22);
            this.join1.TabIndex = 9;
            this.join1.TabStop = true;
            this.join1.Text = "join_like";
            this.join1.UseVisualStyleBackColor = true;
            this.join1.CheckedChanged += new System.EventHandler(this.join1_CheckedChanged);
            // 
            // joinorder
            // 
            this.joinorder.AutoSize = true;
            this.joinorder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.joinorder.Location = new System.Drawing.Point(331, 45);
            this.joinorder.Name = "joinorder";
            this.joinorder.Size = new System.Drawing.Size(91, 22);
            this.joinorder.TabIndex = 10;
            this.joinorder.TabStop = true;
            this.joinorder.Text = "join_order";
            this.joinorder.UseVisualStyleBackColor = true;
            this.joinorder.CheckedChanged += new System.EventHandler(this.joinorder_CheckedChanged);
            // 
            // countbutton
            // 
            this.countbutton.AutoSize = true;
            this.countbutton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countbutton.Location = new System.Drawing.Point(331, 73);
            this.countbutton.Name = "countbutton";
            this.countbutton.Size = new System.Drawing.Size(61, 22);
            this.countbutton.TabIndex = 11;
            this.countbutton.TabStop = true;
            this.countbutton.Text = "count";
            this.countbutton.UseVisualStyleBackColor = true;
            this.countbutton.CheckedChanged += new System.EventHandler(this.countbutton_CheckedChanged);
            // 
            // experience
            // 
            this.experience.AutoSize = true;
            this.experience.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.experience.Location = new System.Drawing.Point(331, 101);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(116, 22);
            this.experience.TabIndex = 12;
            this.experience.TabStop = true;
            this.experience.Text = "experience > 8";
            this.experience.UseVisualStyleBackColor = true;
            this.experience.CheckedChanged += new System.EventHandler(this.experience_CheckedChanged);
            // 
            // updatebutton
            // 
            this.updatebutton.AutoSize = true;
            this.updatebutton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatebutton.Location = new System.Drawing.Point(476, 45);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(70, 22);
            this.updatebutton.TabIndex = 13;
            this.updatebutton.TabStop = true;
            this.updatebutton.Text = "update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.CheckedChanged += new System.EventHandler(this.updatebutton_CheckedChanged);
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 458;
            this.lineShape3.X2 = 458;
            this.lineShape3.Y1 = 17;
            this.lineShape3.Y2 = 131;
            // 
            // alteradd
            // 
            this.alteradd.AutoSize = true;
            this.alteradd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alteradd.Location = new System.Drawing.Point(476, 73);
            this.alteradd.Name = "alteradd";
            this.alteradd.Size = new System.Drawing.Size(85, 22);
            this.alteradd.TabIndex = 14;
            this.alteradd.TabStop = true;
            this.alteradd.Text = "alter_add";
            this.alteradd.UseVisualStyleBackColor = true;
            this.alteradd.CheckedChanged += new System.EventHandler(this.alteradd_CheckedChanged);
            // 
            // dropcolumn
            // 
            this.dropcolumn.AutoSize = true;
            this.dropcolumn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropcolumn.Location = new System.Drawing.Point(476, 101);
            this.dropcolumn.Name = "dropcolumn";
            this.dropcolumn.Size = new System.Drawing.Size(108, 22);
            this.dropcolumn.TabIndex = 15;
            this.dropcolumn.TabStop = true;
            this.dropcolumn.Text = "drop_column";
            this.dropcolumn.UseVisualStyleBackColor = true;
            this.dropcolumn.CheckedChanged += new System.EventHandler(this.dropcolumn_CheckedChanged);
            // 
            // view
            // 
            this.view.AutoSize = true;
            this.view.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.view.Location = new System.Drawing.Point(598, 45);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(56, 22);
            this.view.TabIndex = 16;
            this.view.TabStop = true;
            this.view.Text = "view";
            this.view.UseVisualStyleBackColor = true;
            this.view.CheckedChanged += new System.EventHandler(this.view_CheckedChanged);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(598, 73);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(67, 22);
            this.delete.TabIndex = 17;
            this.delete.TabStop = true;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.CheckedChanged += new System.EventHandler(this.delete_CheckedChanged);
            // 
            // dump
            // 
            this.dump.AutoSize = true;
            this.dump.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dump.Location = new System.Drawing.Point(598, 101);
            this.dump.Name = "dump";
            this.dump.Size = new System.Drawing.Size(62, 22);
            this.dump.TabIndex = 18;
            this.dump.TabStop = true;
            this.dump.Text = "dump";
            this.dump.UseVisualStyleBackColor = true;
            this.dump.CheckedChanged += new System.EventHandler(this.dump_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(472, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Special Commands:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dump);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.view);
            this.Controls.Add(this.dropcolumn);
            this.Controls.Add(this.alteradd);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.experience);
            this.Controls.Add(this.countbutton);
            this.Controls.Add(this.joinorder);
            this.Controls.Add(this.join1);
            this.Controls.Add(this.avgtitlesbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titlesbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Sport";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private testDataSetTableAdapters.teamTableAdapter teamTableAdapter;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton titlesbutton;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.RadioButton avgtitlesbutton;
        private System.Windows.Forms.RadioButton join1;
        private System.Windows.Forms.RadioButton joinorder;
        private System.Windows.Forms.RadioButton countbutton;
        private System.Windows.Forms.RadioButton experience;
        private System.Windows.Forms.RadioButton updatebutton;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.RadioButton alteradd;
        private System.Windows.Forms.RadioButton dropcolumn;
        private System.Windows.Forms.RadioButton view;
        private System.Windows.Forms.RadioButton delete;
        private System.Windows.Forms.RadioButton dump;
        private System.Windows.Forms.Label label4;
    }
}

