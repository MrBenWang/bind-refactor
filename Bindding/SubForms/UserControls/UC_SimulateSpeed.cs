using Bindding.ExcuteClasses;

namespace Bindding.SubForms.UserControls
{
    public partial class UC_SimulateSpeed : BaseConfigUserControl
    {
        protected override void InitData()
        {
            var _tmp = CommonParameter.ConfigParam.simulate_speed;
            this.uc_k_keyword.MyMinMax = _tmp.keyboard_keywords_speed;
            this.uc_m_click_search.MyMinMax = _tmp.mouse_click_search_input;
            this.uc_m_move_search.MyMinMax = _tmp.mouse_move_search_input;
            this.uc_m_scroll.MyMinMax = _tmp.mouse_scroll;
        }

        protected override bool VerifyData()
        {
            if (!this.uc_k_keyword.VerifyMinMax())
            {
                return false;
            }

            if (!this.uc_m_click_search.VerifyMinMax())
            {
                return false;
            }

            if (!this.uc_m_move_search.VerifyMinMax())
            {
                return false;
            }

            if (!this.uc_m_scroll.VerifyMinMax())
            {
                return false;
            }

            return true;
        }

        protected override void UpdateData()
        {
            CommonParameter.ConfigParam.simulate_speed.keyboard_keywords_speed = this.uc_k_keyword.MyMinMax;
            CommonParameter.ConfigParam.simulate_speed.mouse_click_search_input = this.uc_m_click_search.MyMinMax;
            CommonParameter.ConfigParam.simulate_speed.mouse_move_search_input = this.uc_m_move_search.MyMinMax;
            CommonParameter.ConfigParam.simulate_speed.mouse_scroll = this.uc_m_scroll.MyMinMax;
        }
    }
}