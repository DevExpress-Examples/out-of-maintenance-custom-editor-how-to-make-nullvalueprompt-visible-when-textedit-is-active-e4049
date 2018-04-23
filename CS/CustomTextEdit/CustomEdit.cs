using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomTextEdit
{
    public class MyCustomTextEdit : TextEdit
    {
        static MyCustomTextEdit()
        {
            RepositoryItemCustomTextEdit.Register();
        }

        public MyCustomTextEdit() { }

        public override string EditorTypeName
        {
            get { return RepositoryItemCustomTextEdit.CustomTextEditName; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomTextEdit Properties
        {
            get { return base.Properties as RepositoryItemCustomTextEdit; }
        }
    }
}
