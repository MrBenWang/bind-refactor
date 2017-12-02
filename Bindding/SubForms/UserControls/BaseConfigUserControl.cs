using Bindding.ExcuteClasses;

namespace Bindding.SubForms.UserControls
{
    public abstract class BaseConfigUserControl : BaseUserControl
    {
        public BaseConfigUserControl()
        {
            InitializeComponent();
            if (!DesignMode
                && CommonParameter.ConfigParam != null
                && CommonParameter.ConfigParam.change_ip != ChangeIPType.NONE)
            {
                InitData();
            }
        }

        protected abstract void InitializeComponent();

        protected abstract void InitData();

        protected abstract bool VerifyData();

        protected abstract void UpdateData();

        internal virtual bool VerifyAndSaveData()
        {
            bool _isSuccess = VerifyData();
            if (_isSuccess)
            {
                UpdateData();
            }

            return _isSuccess;
        }
    }
}