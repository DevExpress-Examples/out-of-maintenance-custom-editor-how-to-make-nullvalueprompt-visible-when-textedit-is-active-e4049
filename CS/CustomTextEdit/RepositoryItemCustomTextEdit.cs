using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CustomTextEdit
{
    [UserRepositoryItem("Register")]
    public class RepositoryItemCustomTextEdit : RepositoryItemTextEdit
    {
        private bool _nullValuePromptAlwaysVisible;
        public bool NullValuePromptAlwaysVisible
        {
            get
            {
                return _nullValuePromptAlwaysVisible;
            }
            set
            {
                _nullValuePromptAlwaysVisible = value;
                ShowNullPrompt();
            }
        }
        public override string NullValuePrompt
        {
            get
            {
                return base.NullValuePrompt;
            }
            set
            {
                base.NullValuePrompt = value;
                ShowNullPrompt();
            }
        }
        public const string CustomTextEditName = "CustomTextEdit";

        static RepositoryItemCustomTextEdit() { Register(); }
        public RepositoryItemCustomTextEdit() { }

        public override string EditorTypeName { get { return CustomTextEditName; } }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemCustomTextEdit source = item as RepositoryItemCustomTextEdit;
                if (source == null) return;
                NullValuePromptAlwaysVisible = source.NullValuePromptAlwaysVisible;
            }
            finally
            {
                EndUpdate();
            }
        }

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(
                new EditorClassInfo(
                    CustomTextEditName, typeof(MyCustomTextEdit), typeof(RepositoryItemCustomTextEdit),
                    typeof(TextEditViewInfo), new TextEditPainter(), true));
        }

        private void ShowNullPrompt()
        {
            int behaviour = Convert.ToInt32(NullValuePromptAlwaysVisible);
            if (OwnerEdit!=null && OwnerEdit.IsHandleCreated && !string.IsNullOrEmpty(NullValuePrompt))
            {
                SendMessage(OwnerEdit.MaskBox.Handle, 0x1501, (IntPtr)behaviour, NullValuePrompt);
            }
        }

        [DllImport(@"user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, string lp);
    }
}
