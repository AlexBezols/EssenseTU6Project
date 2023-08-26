using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssenseTU6
{
    internal class IW4Offsets
    {
        //intervention
        public UInt32 CheytacIdle = 0xC8A573CF;
        public UInt32 CheytacFire = 0xC8A57D38;
        public UInt32 CheytacFireAds = 0xC8B0A410;
        public UInt32 CheytacRechamber = 0xC8A58A28;
        public UInt32 CheytacRechamberAds = 0xC8A6D320;
        public UInt32 viewmodel_cheytac_idle = 0xC8A57D38;      
        public UInt32 viewmodel_cheytac_fire = 0xC8A58A28;
        public UInt32 viewmodel_cheytac_reload = 0xC8A5A740;
        public UInt32 viewmodel_cheytac_reload_empty = 0xC8A5D7B8;
        public UInt32 viewmodel_cheytac_pullout = 0xC8A62890;
        public UInt32 viewmodel_cheytac_putaway = 0xC8A64DDC;
        public UInt32 viewmodel_cheytac_pullout_quick = 0xC8A67960;
        public UInt32 viewmodel_cheytac_putaway_quick = 0xC8A68CCC;
        public UInt32 viewmodel_cheytac_sprint_in = 0xC8A6A438;
        public UInt32 viewmodel_cheytac_sprint_loop = 0xC8A6B304;
        public UInt32 viewmodel_cheytac_sprint_out = 0xC8A6C470;
        public UInt32 viewmodel_cheytac_rechamber_ads = 0xC8A6D320;
        public UInt32 viewmodel_cheytac_ads_up = 0xC8A6EF30;
        public UInt32 viewmodel_cheytac_ads_down = 0xC8A6EFA3;
        public UInt32 viewmodel_cheytac_ADS_up = 0xC8B0A3DC;
        public UInt32 viewmodel_cheytac_ADS_down = 0xC8B0A3F5;
        public UInt32 viewmodel_cheytac_fire_ads = 0xC8B0A410;
        public UInt32 viewmodel_cheytac_acog_ads_up = 0xC8B0AD14;
        public UInt32 viewmodel_cheytac_acog_ads_down = 0xC8B0AD8B;
        public UInt32 viewmodel_cheytac_acog_ADS_up = 0xC8B0B580;
        public UInt32 viewmodel_cheytac_acog_ADS_down = 0xC8B0B59E;
        public UInt32 viewmodel_cheytac_thermal_ads_up = 0xC8B0CBE4;
        public UInt32 viewmodel_cheytac_thermal_ads_down = 0xC8B0CC5C;
        public UInt32 viewmodel_cheytac_thermal_ADS_up = 0xC8B0D458;
        public UInt32 viewmodel_cheytac_thermal_ADS_down = 0xC8B0D479;
        public UInt32 iSprintInTimeCheytac = 0xC8A6F2CA;
        public UInt32 iDropTimeCheytac = 0xC8A6F2AA;
        public UInt32 iRaiseTimeCheytac = 0xC8A6F2AE;
        //barrett
        public UInt32 viewmodel_barrett_idle = 0xC8830D34;
        public UInt32 viewmodel_barrett_fire = 0xC8831600;
        public UInt32 viewmodel_barrett_reload = 0xC8832244;
        public UInt32 viewmodel_barrett_reload_empty = 0xC883639C;
        public UInt32 viewmodel_barrett_pullout = 0xC883AE44;
        public UInt32 viewmodel_barrett_putaway = 0xC883D7A8;
        public UInt32 viewmodel_barrett_pullout_quick = 0xC883F714;
        public UInt32 viewmodel_barrett_putaway_quick = 0xC8840444;
        public UInt32 viewmodel_barrett_sprint_in = 0xC8841128;
        public UInt32 viewmodel_barrett_sprint_loop = 0xC8842150;
        public UInt32 viewmodel_barrett_sprint_out = 0xC88434DC;
        public UInt32 viewmodel_barrett_ads_up = 0xC884453C;
        public UInt32 viewmodel_barrett_ads_down = 0xC88445AC;
        public UInt32 viewmodel_barrett_ADS_up = 0xC88D144C;
        public UInt32 viewmodel_barrett_ADS_down = 0xC88D1465;
        public UInt32 iSprintInTimeBarrett = 0xC8844952; //
        public UInt32 iDropTimeBarrett = 0xC8844932; //
        public UInt32 iRaiseTimeBarrett = 0xC8844936; //
        //m21
        public UInt32 viewmodel_M14ebr_idle = 0xC8A50C40;
        public UInt32 viewmodel_M14ebr_fire = 0xC8A50C56;
        public UInt32 viewmodel_M14ebr_fire_last = 0xC8A50C6C;
        public UInt32 viewmodel_M14ebr_reload = 0xC8A50C87;
        public UInt32 viewmodel_M14ebr_reload_empty = 0xC8A50C9F;
        public UInt32 viewmodel_M14ebr_pullout = 0xC8A50CBD;
        public UInt32 viewmodel_M14ebr_pullout_first = 0xC8A50CD6;
        public UInt32 viewmodel_M14ebr_putaway = 0xC8A50CF5;
        public UInt32 viewmodel_M14ebr_pullout_fast = 0xC8A50D0E;
        public UInt32 viewmodel_M14ebr_sprint_in = 0xC8A50D2C;
        public UInt32 viewmodel_M14ebr_sprint_loop = 0xC8A50D47;
        public UInt32 viewmodel_M14ebr_sprint_out = 0xC8A50D64;
        public UInt32 viewmodel_M14ebr_fire_ads = 0xC8A50D80;
        public UInt32 viewmodel_M14ebr_scope_ADS_up = 0xC8A50D9A;
        public UInt32 viewmodel_M14ebr_scope_ADS_down = 0xC8A50DB8;
        public UInt32 viewmodel_M14ebr_acog_ADS_up = 0xC8A51694;
        public UInt32 viewmodel_M14ebr_acog_ADS_down = 0xC8A516B0;
        public UInt32 viewmodel_M14ebr_thermal_ADS_up = 0xC8A53588;
        public UInt32 viewmodel_M14ebr_thermal_ADS_down = 0xC8A535A8;
        public UInt32 iSprintInTimeM21 = 0xC899B936; //
        public UInt32 iDropTimeM21 = 0xC899B916; //
        public UInt32 iRaiseTimeM21 = 0xC899B91A; //
        //wa2000
        public UInt32 viewmodel_wa2000_hb_open_idle = 0xC88D8597;
        public UInt32 viewmodel_wa2000_hb_open_fire = 0xC88D8EA0;
        public UInt32 viewmodel_wa2000_hb_open_reload = 0xC88D997C;
        public UInt32 viewmodel_wa2000_hb_open_reload_empty = 0xC88DD5E0;
        public UInt32 viewmodel_wa2000_hb_open_pullout = 0xC88E1D7C;
        public UInt32 viewmodel_wa2000_hb_open_first_time_pullout = 0xC88E39F0;
        public UInt32 viewmodel_wa2000_hb_open_putaway = 0xC88E5E2C;
        public UInt32 viewmodel_wa2000_hb_open_quick_pullout = 0xC88E7A24;
        public UInt32 viewmodel_wa2000_hb_open_quick_putaway = 0xC88E92B8;
        public UInt32 viewmodel_wa2000_hb_open_sprint_in = 0xC88EA280;
        public UInt32 viewmodel_wa2000_hb_open_sprint_loop = 0xC88EB208;
        public UInt32 viewmodel_wa2000_hb_open_sprint_out = 0xC88EC260;
        public UInt32 viewmodel_wa2000_ads_up = 0xC88EDC70;
        public UInt32 viewmodel_wa2000_ads_down = 0xC88EDD2E;
        public UInt32 viewmodel_wa2000_ADS_up = 0xC898011B;
        public UInt32 viewmodel_wa2000_ADS_down = 0xC8980133;
        public UInt32 iSprintInTimeWA = 0xC88EE0A2; //
        public UInt32 iDropTimeWA = 0xC88EE082; //
        public UInt32 iFirstRaiseTimeWA = 0xC88EE086; //
        //m4
        public UInt32 viewmodel_M4_idle = 0xC8590418;
        public UInt32 viewmodel_M4_fire = 0xC859042A;
        public UInt32 viewmodel_M4_reload = 0xC859043C;
        public UInt32 viewmodel_M4_reload_empty = 0xC8590450;
        public UInt32 viewmodel_M4_pullout = 0xC859046A;
        public UInt32 viewmodel_m4_first_time_pullout = 0xC8585800;
        public UInt32 viewmodel_M4_putaway = 0xC859047F;
        public UInt32 viewmodel_M4_quick_pullout = 0xC8590494;
        public UInt32 viewmodel_M4_quick_putaway = 0xC85904AF;
        public UInt32 viewmodel_M4_sprint_in = 0xC85904CA;
        public UInt32 viewmodel_M4_sprint_loop = 0xC85904E1;
        public UInt32 viewmodel_M4_sprint_out = 0xC85904FA;
        public UInt32 viewmodel_M4_shotgun_shotty_idle = 0xC76B1588;
        public UInt32 viewmodel_M4_shotgun_shotty_fire = 0xC76B15A9;
        public UInt32 viewmodel_M4_shotgun_shotty_rechamber = 0xC76B15CA;
        public UInt32 viewmodel_M4_shotgun_shotty_reload_loop = 0xC76B15F0;
        public UInt32 viewmodel_M4_shotgun_shotty_reload_start = 0xC76B1618;
        public UInt32 viewmodel_M4_shotgun_shotty_reload_end = 0xC76B1641;
        public UInt32 viewmodel_M4_shotgun_shotty_pullout = 0xC76B1668;
        public UInt32 viewmodel_M4_shotgun_shotty_putaway = 0xC76B168C;
        public UInt32 viewmodel_M4_shotgun_shotty_sprint_in = 0xC76B16D5;
        public UInt32 viewmodel_M4_shotgun_shotty_sprint_loop = 0xC76B16FB;
        public UInt32 viewmodel_M4_shotgun_shotty_sprint_out = 0xC76B1723;

    }
}
