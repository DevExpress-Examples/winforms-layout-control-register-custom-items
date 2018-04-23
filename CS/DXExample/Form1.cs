using System;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using System.IO;

namespace DXExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
    }
    public class MyLayoutControl : LayoutControl {
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore() {
            return new MyLayoutControlImplementor(this);
        }
    }
    public class MyLayoutControlImplementor : LayoutControlImplementor {
        public MyLayoutControlImplementor(ILayoutControlOwner owner) : base(owner) { }
        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent) {
            return new MyLayoutControlGroup();
        }
        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent) {
            return new MyLayoutControlItem();
        }
    }
    public class MyLayoutControlGroup : LayoutControlGroup {
        public override bool TextVisible {
            get {
                return true;
            }
            set {

            }
        }
        public override string Text {
            get {
                return DateTime.Now.ToLongTimeString();
            }
            set {

            }
        }
    }
    public class MyLayoutControlItem : LayoutControlItem {
        public override bool TextVisible {
            get {
                return true;
            }
            set {

            }
        }
        public override string Text {
            get {
                return DateTime.Now.ToLongTimeString();
            }
            set {

            }
        }
    }
}