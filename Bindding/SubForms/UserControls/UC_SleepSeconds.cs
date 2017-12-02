using Bindding.ExcuteClasses;

namespace Bindding.SubForms.UserControls
{
    public partial class UC_SleepSeconds : BaseConfigUserControl
    {
        protected override void InitData()
        {
            var _tmp = CommonParameter.ConfigParam.sleep_seconds;
            this.uc_after_search.MyMinMax = _tmp.after_search;
            this.uc_baidu_search.MyMinMax = _tmp.baidu_search;
            this.uc_popup.MyMinMax = _tmp.pop_up;
            this.uc_recon.MyMinMax = _tmp.recon_time;
        }

        protected override bool VerifyData()
        {
            if (!this.uc_after_search.VerifyMinMax())
            {
                return false;
            }

            if (!this.uc_baidu_search.VerifyMinMax())
            {
                return false;
            }

            if (!this.uc_popup.VerifyMinMax())
            {
                return false;
            }

            if (!this.uc_recon.VerifyMinMax())
            {
                return false;
            }

            return true;
        }

        protected override void UpdateData()
        {
            CommonParameter.ConfigParam.sleep_seconds.after_search = this.uc_after_search.MyMinMax;
            CommonParameter.ConfigParam.sleep_seconds.baidu_search = this.uc_baidu_search.MyMinMax;
            CommonParameter.ConfigParam.sleep_seconds.pop_up = this.uc_popup.MyMinMax;
            CommonParameter.ConfigParam.sleep_seconds.recon_time = this.uc_recon.MyMinMax;
        }
    }
}