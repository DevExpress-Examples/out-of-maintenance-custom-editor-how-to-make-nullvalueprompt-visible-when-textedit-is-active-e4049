using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CustomTextEdit
{
    public partial class Form1 : Form
    {
        MyCustomTextEdit myCustomTextEdit1;

        public Form1()
        {
            InitializeComponent();

            //myCustomTextEdit1
            myCustomTextEdit1 = new MyCustomTextEdit();
            Controls.Add(myCustomTextEdit1);           
            
            //checkEdit1
            checkEdit1.CheckStateChanged += checkEdit1_CheckStateChanged;

            //textEdit1
            textEdit1.EditValueChanged += textEdit1_EditValueChanged;
            textEdit1.EditValue = "Enter some value";
            
        }

        ~Form1()
        {
            checkEdit1.CheckStateChanged -= checkEdit1_CheckStateChanged;
            textEdit1.EditValueChanged -= textEdit1_EditValueChanged;
        }

        void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            myCustomTextEdit1.Properties.NullValuePrompt = edit.EditValue.ToString();
        }

        void checkEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            myCustomTextEdit1.Properties.NullValuePromptAlwaysVisible = edit.Checked;
        }
    }
}
