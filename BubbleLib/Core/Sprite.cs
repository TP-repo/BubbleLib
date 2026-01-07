using YYTKInterop;

namespace BubbleLib.Core
{
    public class Sprite
    {
        private static readonly Dictionary<string, Sprite> loadedSprites = new();

        public static Sprite AlchemyChestBroken => GetSpriteFromAsset("s_alchemy_chest_broken");
        public static Sprite AlchemyChestClose => GetSpriteFromAsset("s_alchemy_chest_close");
        public static Sprite AlchemyChestOpen => GetSpriteFromAsset("s_alchemy_chest_open");
        public static Sprite AlchemyStationBroken => GetSpriteFromAsset("s_alchemy_station_broken");
        public static Sprite AlchemyStationFinishing =>
            GetSpriteFromAsset("s_alchemy_station_finishing");
        public static Sprite AlchemyStationIdle => GetSpriteFromAsset("s_alchemy_station_idle");
        public static Sprite AlchemyStationWorking =>
            GetSpriteFromAsset("s_alchemy_station_working");
        public static Sprite Black => GetSpriteFromAsset("s_black");
        public static Sprite Block => GetSpriteFromAsset("s_block");
        public static Sprite BubbleBigCritical => GetSpriteFromAsset("s_bubble_big_critical");
        public static Sprite BubbleBigProjectileExplosion =>
            GetSpriteFromAsset("s_bubble_big_projectile_explosion");
        public static Sprite BubbleBigSquareCritical =>
            GetSpriteFromAsset("s_bubble_big_square_critical");
        public static Sprite BubbleBigSquareProjectileExplosion =>
            GetSpriteFromAsset("s_bubble_big_square_projectile_explosion");
        public static Sprite BubbleBigSquare => GetSpriteFromAsset("s_bubble_big_square");
        public static Sprite BubbleBigStarCritical =>
            GetSpriteFromAsset("s_bubble_big_star_critical");
        public static Sprite BubbleBigStarProjectileExplosion =>
            GetSpriteFromAsset("s_bubble_big_star_projectile_explosion");
        public static Sprite BubbleBigStar => GetSpriteFromAsset("s_bubble_big_star");
        public static Sprite BubbleBig => GetSpriteFromAsset("s_bubble_big");
        public static Sprite BubbleExplosionOverlay =>
            GetSpriteFromAsset("s_bubble_explosion_overlay");
        public static Sprite BubbleExplosion => GetSpriteFromAsset("s_bubble_explosion");
        public static Sprite BubbleGun => GetSpriteFromAsset("s_bubble_gun");
        public static Sprite BubbleJellyfishMask => GetSpriteFromAsset("s_bubble_jellyfish_mask");
        public static Sprite BubbleJellyfishTexture =>
            GetSpriteFromAsset("s_bubble_jellyfish_texture");
        public static Sprite BubbleJellyfish => GetSpriteFromAsset("s_bubble_jellyfish");
        public static Sprite BubbleRegular => GetSpriteFromAsset("s_bubble_regular");
        public static Sprite BubbleVfxOld => GetSpriteFromAsset("s_bubble_vfx_old");
        public static Sprite BubbleVfx => GetSpriteFromAsset("s_bubble_vfx");
        public static Sprite BubbleXpUi => GetSpriteFromAsset("s_bubble_xp_ui");
        public static Sprite CameraArea => GetSpriteFromAsset("s_camera_area");
        public static Sprite CameraOffset => GetSpriteFromAsset("s_camera_offset");
        public static Sprite ChangeArrow => GetSpriteFromAsset("s_change_arrow");
        public static Sprite CoinCrystal01 => GetSpriteFromAsset("s_coin_crystal_01");
        public static Sprite CoinCrystal02 => GetSpriteFromAsset("s_coin_crystal_02");
        public static Sprite CoinCrystalUi => GetSpriteFromAsset("s_coin_crystal_ui");
        public static Sprite CoinFlask01 => GetSpriteFromAsset("s_coin_flask_01");
        public static Sprite CoinFlask02 => GetSpriteFromAsset("s_coin_flask_02");
        public static Sprite CoinFlaskUi => GetSpriteFromAsset("s_coin_flask_ui");
        public static Sprite CoinMush01 => GetSpriteFromAsset("s_coin_mush_01");
        public static Sprite CoinMush02 => GetSpriteFromAsset("s_coin_mush_02");
        public static Sprite CoinMushUi => GetSpriteFromAsset("s_coin_mush_ui");
        public static Sprite CoinObsidian01 => GetSpriteFromAsset("s_coin_obsidian_01");
        public static Sprite CoinObsidian02 => GetSpriteFromAsset("s_coin_obsidian_02");
        public static Sprite CoinObsidianUi => GetSpriteFromAsset("s_coin_obsidian_ui");
        public static Sprite CoinScrap01 => GetSpriteFromAsset("s_coin_scrap_01");
        public static Sprite CoinScrap02 => GetSpriteFromAsset("s_coin_scrap_02");
        public static Sprite CoinScrapUi => GetSpriteFromAsset("s_coin_scrap_ui");
        public static Sprite CoinShell01 => GetSpriteFromAsset("s_coin_shell_01");
        public static Sprite CoinShell02 => GetSpriteFromAsset("s_coin_shell_02");
        public static Sprite CoinShellUi => GetSpriteFromAsset("s_coin_shell_ui");
        public static Sprite CollectableDivider => GetSpriteFromAsset("s_collectable_divider");
        public static Sprite Coral01 => GetSpriteFromAsset("s_coral_01");
        public static Sprite Coral02 => GetSpriteFromAsset("s_coral_02");
        public static Sprite Coral03 => GetSpriteFromAsset("s_coral_03");
        public static Sprite Coral04 => GetSpriteFromAsset("s_coral_04");
        public static Sprite Coral05 => GetSpriteFromAsset("s_coral_05");
        public static Sprite Coral06 => GetSpriteFromAsset("s_coral_06");
        public static Sprite Coral07 => GetSpriteFromAsset("s_coral_07");
        public static Sprite Coral08 => GetSpriteFromAsset("s_coral_08");
        public static Sprite Coral09 => GetSpriteFromAsset("s_coral_09");
        public static Sprite Coral10 => GetSpriteFromAsset("s_coral_10");
        public static Sprite Coral11 => GetSpriteFromAsset("s_coral_11");
        public static Sprite Coral12 => GetSpriteFromAsset("s_coral_12");
        public static Sprite Coral13 => GetSpriteFromAsset("s_coral_13");
        public static Sprite Coral14 => GetSpriteFromAsset("s_coral_14");
        public static Sprite Coral15 => GetSpriteFromAsset("s_coral_15");
        public static Sprite Coral16 => GetSpriteFromAsset("s_coral_16");
        public static Sprite Coral17 => GetSpriteFromAsset("s_coral_17");
        public static Sprite Coral18 => GetSpriteFromAsset("s_coral_18");
        public static Sprite CoralBubble01 => GetSpriteFromAsset("s_coral_bubble_01");
        public static Sprite CoralBubble02 => GetSpriteFromAsset("s_coral_bubble_02");
        public static Sprite CoralBubble03 => GetSpriteFromAsset("s_coral_bubble_03");
        public static Sprite CoralBubble04 => GetSpriteFromAsset("s_coral_bubble_04");
        public static Sprite CoralBubble05 => GetSpriteFromAsset("s_coral_bubble_05");
        public static Sprite CoralBubble06 => GetSpriteFromAsset("s_coral_bubble_06");
        public static Sprite CoralBubble07 => GetSpriteFromAsset("s_coral_bubble_07");
        public static Sprite CoralBubble08 => GetSpriteFromAsset("s_coral_bubble_08");
        public static Sprite CoralBubble09 => GetSpriteFromAsset("s_coral_bubble_09");
        public static Sprite CoralBubble10 => GetSpriteFromAsset("s_coral_bubble_10");
        public static Sprite CoralBubble11 => GetSpriteFromAsset("s_coral_bubble_11");
        public static Sprite CoralBubble12 => GetSpriteFromAsset("s_coral_bubble_12");
        public static Sprite CoralSolid01 => GetSpriteFromAsset("s_coral_solid_01");
        public static Sprite CoralSolid02 => GetSpriteFromAsset("s_coral_solid_02");
        public static Sprite CoralSolid03 => GetSpriteFromAsset("s_coral_solid_03");
        public static Sprite CoralSolid04 => GetSpriteFromAsset("s_coral_solid_04");
        public static Sprite CoralSolid05 => GetSpriteFromAsset("s_coral_solid_05");
        public static Sprite CoralSolid06 => GetSpriteFromAsset("s_coral_solid_06");
        public static Sprite CoralSolid07 => GetSpriteFromAsset("s_coral_solid_07");
        public static Sprite CoralSolid08 => GetSpriteFromAsset("s_coral_solid_08");
        public static Sprite CoralSolid09 => GetSpriteFromAsset("s_coral_solid_09");
        public static Sprite CrystalBlock01 => GetSpriteFromAsset("s_crystal_block_01");
        public static Sprite CrystalBlock02 => GetSpriteFromAsset("s_crystal_block_02");
        public static Sprite CrystalBlock03 => GetSpriteFromAsset("s_crystal_block_03");
        public static Sprite CrystalBlockVfx01 => GetSpriteFromAsset("s_crystal_block_vfx_01");
        public static Sprite CrystalBlockVfx02 => GetSpriteFromAsset("s_crystal_block_vfx_02");
        public static Sprite CursorOcean => GetSpriteFromAsset("s_cursor_ocean");
        public static Sprite Cursor => GetSpriteFromAsset("s_cursor");
        public static Sprite DescLine => GetSpriteFromAsset("s_desc_line");
        public static Sprite EmeraldRamp => GetSpriteFromAsset("s_emerald_ramp");
        public static Sprite EnemyDeathExplosion => GetSpriteFromAsset("s_enemy_death_explosion");
        public static Sprite EntityHealthbarBg => GetSpriteFromAsset("s_entity_healthbar_bg");
        public static Sprite EntityHealthbarProgress =>
            GetSpriteFromAsset("s_entity_healthbar_progress");
        public static Sprite Fence01 => GetSpriteFromAsset("s_fence_01");
        public static Sprite Fence02 => GetSpriteFromAsset("s_fence_02");
        public static Sprite Flower01 => GetSpriteFromAsset("s_flower_01");
        public static Sprite Flower02 => GetSpriteFromAsset("s_flower_02");
        public static Sprite Flower03 => GetSpriteFromAsset("s_flower_03");
        public static Sprite Flower04 => GetSpriteFromAsset("s_flower_04");
        public static Sprite Flower05 => GetSpriteFromAsset("s_flower_05");
        public static Sprite Flower06 => GetSpriteFromAsset("s_flower_06");
        public static Sprite Flower07 => GetSpriteFromAsset("s_flower_07");
        public static Sprite Flower08 => GetSpriteFromAsset("s_flower_08");
        public static Sprite ForegroundBorder => GetSpriteFromAsset("s_foreground_border");
        public static Sprite FriendlyBubbleExplode =>
            GetSpriteFromAsset("s_friendly_bubble_explode");
        public static Sprite FriendlyBubbleIdle => GetSpriteFromAsset("s_friendly_bubble_idle");
        public static Sprite GagonfeLogo => GetSpriteFromAsset("s_gagonfe_logo");
        public static Sprite GameLogoBnw => GetSpriteFromAsset("s_game_logo_bnw");
        public static Sprite GameLogoRegular => GetSpriteFromAsset("s_game_logo_regular");
        public static Sprite GamepadPad => GetSpriteFromAsset("s_gamepad_pad");
        public static Sprite GlacialRamp => GetSpriteFromAsset("s_glacial_ramp");
        public static Sprite GodrayDiagonal01 => GetSpriteFromAsset("s_godray_diagonal_01");
        public static Sprite GodrayDiagonal02 => GetSpriteFromAsset("s_godray_diagonal_02");
        public static Sprite GodrayDiagonal03 => GetSpriteFromAsset("s_godray_diagonal_03");
        public static Sprite GoldRamp => GetSpriteFromAsset("s_gold_ramp");
        public static Sprite Grass01 => GetSpriteFromAsset("s_grass_01");
        public static Sprite Grass02 => GetSpriteFromAsset("s_grass_02");
        public static Sprite Grass03 => GetSpriteFromAsset("s_grass_03");
        public static Sprite Grass04 => GetSpriteFromAsset("s_grass_04");
        public static Sprite Grass05 => GetSpriteFromAsset("s_grass_05");
        public static Sprite Grass06 => GetSpriteFromAsset("s_grass_06");
        public static Sprite Grass07 => GetSpriteFromAsset("s_grass_07");
        public static Sprite GuideArrow => GetSpriteFromAsset("s_guide_arrow");
        public static Sprite GunShotImpact => GetSpriteFromAsset("s_gun_shot_impact");
        public static Sprite GunShotVfx01 => GetSpriteFromAsset("s_gun_shot_vfx_01");
        public static Sprite HammockBlueBreak => GetSpriteFromAsset("s_hammock_blue_break");
        public static Sprite HammockBlueGetUp => GetSpriteFromAsset("s_hammock_blue_get_up");
        public static Sprite HammockBlueIdle => GetSpriteFromAsset("s_hammock_blue_idle");
        public static Sprite HammockBlueSleep01 => GetSpriteFromAsset("s_hammock_blue_sleep_01");
        public static Sprite HammockBlueSleep02 => GetSpriteFromAsset("s_hammock_blue_sleep_02");
        public static Sprite HammockBlueToSleep => GetSpriteFromAsset("s_hammock_blue_to_sleep");
        public static Sprite HammockPurpleBreak => GetSpriteFromAsset("s_hammock_purple_break");
        public static Sprite HammockPurpleGetUp => GetSpriteFromAsset("s_hammock_purple_get_up");
        public static Sprite HammockPurpleIdle => GetSpriteFromAsset("s_hammock_purple_idle");
        public static Sprite HammockPurpleSleep01 =>
            GetSpriteFromAsset("s_hammock_purple_sleep_01");
        public static Sprite HammockPurpleSleep02 =>
            GetSpriteFromAsset("s_hammock_purple_sleep_02");
        public static Sprite HammockPurpleToSleep =>
            GetSpriteFromAsset("s_hammock_purple_to_sleep");
        public static Sprite HammockRedBreak => GetSpriteFromAsset("s_hammock_red_break");
        public static Sprite HammockRedGetUp => GetSpriteFromAsset("s_hammock_red_get_up");
        public static Sprite HammockRedIdle => GetSpriteFromAsset("s_hammock_red_idle");
        public static Sprite HammockRedSleep01 => GetSpriteFromAsset("s_hammock_red_sleep_01");
        public static Sprite HammockRedSleep02 => GetSpriteFromAsset("s_hammock_red_sleep_02");
        public static Sprite HammockRedToSleep => GetSpriteFromAsset("s_hammock_red_to_sleep");
        public static Sprite HitVfx01 => GetSpriteFromAsset("s_hit_vfx_01");
        public static Sprite HitVfx02 => GetSpriteFromAsset("s_hit_vfx_02");
        public static Sprite HitVfx03 => GetSpriteFromAsset("s_hit_vfx_03");
        public static Sprite HitVfx04 => GetSpriteFromAsset("s_hit_vfx_04");
        public static Sprite InputGamepadA => GetSpriteFromAsset("s_input_gamepad_a");
        public static Sprite InputGamepadB => GetSpriteFromAsset("s_input_gamepad_b");
        public static Sprite InputGamepadCircle => GetSpriteFromAsset("s_input_gamepad_circle");
        public static Sprite InputGamepadCross => GetSpriteFromAsset("s_input_gamepad_cross");
        public static Sprite InputGamepadJoystickL =>
            GetSpriteFromAsset("s_input_gamepad_joystick_l");
        public static Sprite InputGamepadJoystickR =>
            GetSpriteFromAsset("s_input_gamepad_joystick_r");
        public static Sprite InputGamepadJoysticks =>
            GetSpriteFromAsset("s_input_gamepad_joysticks");
        public static Sprite InputGamepadL1 => GetSpriteFromAsset("s_input_gamepad_l1");
        public static Sprite InputGamepadL2 => GetSpriteFromAsset("s_input_gamepad_l2");
        public static Sprite InputGamepadL2r2 => GetSpriteFromAsset("s_input_gamepad_l2r2");
        public static Sprite InputGamepadLb => GetSpriteFromAsset("s_input_gamepad_lb");
        public static Sprite InputGamepadLt => GetSpriteFromAsset("s_input_gamepad_lt");
        public static Sprite InputGamepadLtrt => GetSpriteFromAsset("s_input_gamepad_ltrt");
        public static Sprite InputGamepadPadDown => GetSpriteFromAsset("s_input_gamepad_pad_down");
        public static Sprite InputGamepadPadLeft => GetSpriteFromAsset("s_input_gamepad_pad_left");
        public static Sprite InputGamepadPadRight =>
            GetSpriteFromAsset("s_input_gamepad_pad_right");
        public static Sprite InputGamepadPadUp => GetSpriteFromAsset("s_input_gamepad_pad_up");
        public static Sprite InputGamepadR1 => GetSpriteFromAsset("s_input_gamepad_r1");
        public static Sprite InputGamepadR2 => GetSpriteFromAsset("s_input_gamepad_r2");
        public static Sprite InputGamepadRb => GetSpriteFromAsset("s_input_gamepad_rb");
        public static Sprite InputGamepadRt => GetSpriteFromAsset("s_input_gamepad_rt");
        public static Sprite InputGamepadSelect => GetSpriteFromAsset("s_input_gamepad_select");
        public static Sprite InputGamepadSquare => GetSpriteFromAsset("s_input_gamepad_square");
        public static Sprite InputGamepadTriangle => GetSpriteFromAsset("s_input_gamepad_triangle");
        public static Sprite InputGamepadX => GetSpriteFromAsset("s_input_gamepad_x");
        public static Sprite InputGamepadY => GetSpriteFromAsset("s_input_gamepad_y");
        public static Sprite InputKeyboard0 => GetSpriteFromAsset("s_input_keyboard_0");
        public static Sprite InputKeyboard1 => GetSpriteFromAsset("s_input_keyboard_1");
        public static Sprite InputKeyboard2 => GetSpriteFromAsset("s_input_keyboard_2");
        public static Sprite InputKeyboard3 => GetSpriteFromAsset("s_input_keyboard_3");
        public static Sprite InputKeyboard4 => GetSpriteFromAsset("s_input_keyboard_4");
        public static Sprite InputKeyboard5 => GetSpriteFromAsset("s_input_keyboard_5");
        public static Sprite InputKeyboard6 => GetSpriteFromAsset("s_input_keyboard_6");
        public static Sprite InputKeyboard7 => GetSpriteFromAsset("s_input_keyboard_7");
        public static Sprite InputKeyboard8 => GetSpriteFromAsset("s_input_keyboard_8");
        public static Sprite InputKeyboard9 => GetSpriteFromAsset("s_input_keyboard_9");
        public static Sprite InputKeyboardA => GetSpriteFromAsset("s_input_keyboard_a");
        public static Sprite InputKeyboardAlt => GetSpriteFromAsset("s_input_keyboard_alt");
        public static Sprite InputKeyboardArrowDown =>
            GetSpriteFromAsset("s_input_keyboard_arrow_down");
        public static Sprite InputKeyboardArrowLeft =>
            GetSpriteFromAsset("s_input_keyboard_arrow_left");
        public static Sprite InputKeyboardArrowRight =>
            GetSpriteFromAsset("s_input_keyboard_arrow_right");
        public static Sprite InputKeyboardArrowUp =>
            GetSpriteFromAsset("s_input_keyboard_arrow_up");
        public static Sprite InputKeyboardArrows => GetSpriteFromAsset("s_input_keyboard_arrows");
        public static Sprite InputKeyboardB => GetSpriteFromAsset("s_input_keyboard_b");
        public static Sprite InputKeyboardBackspace =>
            GetSpriteFromAsset("s_input_keyboard_backspace");
        public static Sprite InputKeyboardC => GetSpriteFromAsset("s_input_keyboard_c");
        public static Sprite InputKeyboardCtrl => GetSpriteFromAsset("s_input_keyboard_ctrl");
        public static Sprite InputKeyboardD => GetSpriteFromAsset("s_input_keyboard_d");
        public static Sprite InputKeyboardE => GetSpriteFromAsset("s_input_keyboard_e");
        public static Sprite InputKeyboardEnter => GetSpriteFromAsset("s_input_keyboard_enter");
        public static Sprite InputKeyboardEscape => GetSpriteFromAsset("s_input_keyboard_escape");
        public static Sprite InputKeyboardF => GetSpriteFromAsset("s_input_keyboard_f");
        public static Sprite InputKeyboardG => GetSpriteFromAsset("s_input_keyboard_g");
        public static Sprite InputKeyboardH => GetSpriteFromAsset("s_input_keyboard_h");
        public static Sprite InputKeyboardI => GetSpriteFromAsset("s_input_keyboard_i");
        public static Sprite InputKeyboardJ => GetSpriteFromAsset("s_input_keyboard_j");
        public static Sprite InputKeyboardK => GetSpriteFromAsset("s_input_keyboard_k");
        public static Sprite InputKeyboardL => GetSpriteFromAsset("s_input_keyboard_l");
        public static Sprite InputKeyboardM => GetSpriteFromAsset("s_input_keyboard_m");
        public static Sprite InputKeyboardN => GetSpriteFromAsset("s_input_keyboard_n");
        public static Sprite InputKeyboardO => GetSpriteFromAsset("s_input_keyboard_o");
        public static Sprite InputKeyboardP => GetSpriteFromAsset("s_input_keyboard_p");
        public static Sprite InputKeyboardQ => GetSpriteFromAsset("s_input_keyboard_q");
        public static Sprite InputKeyboardR => GetSpriteFromAsset("s_input_keyboard_r");
        public static Sprite InputKeyboardS => GetSpriteFromAsset("s_input_keyboard_s");
        public static Sprite InputKeyboardShift => GetSpriteFromAsset("s_input_keyboard_shift");
        public static Sprite InputKeyboardSpace => GetSpriteFromAsset("s_input_keyboard_space");
        public static Sprite InputKeyboardT => GetSpriteFromAsset("s_input_keyboard_t");
        public static Sprite InputKeyboardTab => GetSpriteFromAsset("s_input_keyboard_tab");
        public static Sprite InputKeyboardU => GetSpriteFromAsset("s_input_keyboard_u");
        public static Sprite InputKeyboardV => GetSpriteFromAsset("s_input_keyboard_v");
        public static Sprite InputKeyboardW => GetSpriteFromAsset("s_input_keyboard_w");
        public static Sprite InputKeyboardX => GetSpriteFromAsset("s_input_keyboard_x");
        public static Sprite InputKeyboardY => GetSpriteFromAsset("s_input_keyboard_y");
        public static Sprite InputKeyboardZ => GetSpriteFromAsset("s_input_keyboard_z");
        public static Sprite InputMouseLmb => GetSpriteFromAsset("s_input_mouse_lmb");
        public static Sprite InputMouseMiddle => GetSpriteFromAsset("s_input_mouse_middle");
        public static Sprite InputMouseRmb => GetSpriteFromAsset("s_input_mouse_rmb");
        public static Sprite InputMouse => GetSpriteFromAsset("s_input_mouse");
        public static Sprite InventoryBgCloseGuideBg =>
            GetSpriteFromAsset("s_inventory_bg_close_guide_bg");
        public static Sprite InventoryBg => GetSpriteFromAsset("s_inventory_bg");
        public static Sprite InventorySlot => GetSpriteFromAsset("s_inventory_slot");
        public static Sprite InvisibleBlock => GetSpriteFromAsset("s_invisible_block");
        public static Sprite IslandBg01 => GetSpriteFromAsset("s_island_bg_01");
        public static Sprite IslandBg02 => GetSpriteFromAsset("s_island_bg_02");
        public static Sprite IslandBg03 => GetSpriteFromAsset("s_island_bg_03");
        public static Sprite IslandBg04 => GetSpriteFromAsset("s_island_bg_04");
        public static Sprite IslandBg05 => GetSpriteFromAsset("s_island_bg_05");
        public static Sprite IslandBush01 => GetSpriteFromAsset("s_island_bush_01");
        public static Sprite IslandBush02 => GetSpriteFromAsset("s_island_bush_02");
        public static Sprite IslandBush03 => GetSpriteFromAsset("s_island_bush_03");
        public static Sprite IslandBush04 => GetSpriteFromAsset("s_island_bush_04");
        public static Sprite IslandBush05 => GetSpriteFromAsset("s_island_bush_05");
        public static Sprite IslandBush06 => GetSpriteFromAsset("s_island_bush_06");
        public static Sprite IslandTree01 => GetSpriteFromAsset("s_island_tree_01");
        public static Sprite IslandTree02 => GetSpriteFromAsset("s_island_tree_02");
        public static Sprite IslandTree03 => GetSpriteFromAsset("s_island_tree_03");
        public static Sprite IslandTree04 => GetSpriteFromAsset("s_island_tree_04");
        public static Sprite IslandTree05 => GetSpriteFromAsset("s_island_tree_05");
        public static Sprite IslandTree06 => GetSpriteFromAsset("s_island_tree_06");
        public static Sprite IslandTree07 => GetSpriteFromAsset("s_island_tree_07");
        public static Sprite IslandTree08 => GetSpriteFromAsset("s_island_tree_08");
        public static Sprite IslandWaterBack => GetSpriteFromAsset("s_island_water_back");
        public static Sprite IslandWaterFront => GetSpriteFromAsset("s_island_water_front");
        public static Sprite JellyfishArea => GetSpriteFromAsset("s_jellyfish_area");
        public static Sprite JellyfishExplosionIcon =>
            GetSpriteFromAsset("s_jellyfish_explosion_icon");
        public static Sprite JellyfishExplosionMask =>
            GetSpriteFromAsset("s_jellyfish_explosion_mask");
        public static Sprite JellyfishGlacialGreenHurt =>
            GetSpriteFromAsset("s_jellyfish_glacial_green_hurt");
        public static Sprite JellyfishGlacialGreenIdle =>
            GetSpriteFromAsset("s_jellyfish_glacial_green_idle");
        public static Sprite JellyfishGlacialGreenMove =>
            GetSpriteFromAsset("s_jellyfish_glacial_green_move");
        public static Sprite JellyfishGlacialPurpleHurt =>
            GetSpriteFromAsset("s_jellyfish_glacial_purple_hurt");
        public static Sprite JellyfishGlacialPurpleIdle =>
            GetSpriteFromAsset("s_jellyfish_glacial_purple_idle");
        public static Sprite JellyfishGlacialPurpleMove =>
            GetSpriteFromAsset("s_jellyfish_glacial_purple_move");
        public static Sprite JellyfishGlacialRedHurt =>
            GetSpriteFromAsset("s_jellyfish_glacial_red_hurt");
        public static Sprite JellyfishGlacialRedIdle =>
            GetSpriteFromAsset("s_jellyfish_glacial_red_idle");
        public static Sprite JellyfishGlacialRedMove =>
            GetSpriteFromAsset("s_jellyfish_glacial_red_move");
        public static Sprite JellyfishHealthbarBg => GetSpriteFromAsset("s_jellyfish_healthbar_bg");
        public static Sprite JellyfishHealthbarProgress =>
            GetSpriteFromAsset("s_jellyfish_healthbar_progress");
        public static Sprite JellyfishHitVfx01 => GetSpriteFromAsset("s_jellyfish_hit_vfx_01");
        public static Sprite JellyfishMagmaBlueIdle =>
            GetSpriteFromAsset("s_jellyfish_magma_blue_idle");
        public static Sprite JellyfishMagmaBlueMove =>
            GetSpriteFromAsset("s_jellyfish_magma_blue_move");
        public static Sprite JellyfishMagmaBlueShock =>
            GetSpriteFromAsset("s_jellyfish_magma_blue_shock");
        public static Sprite JellyfishMagmaRedIdle =>
            GetSpriteFromAsset("s_jellyfish_magma_red_idle");
        public static Sprite JellyfishMagmaRedMove =>
            GetSpriteFromAsset("s_jellyfish_magma_red_move");
        public static Sprite JellyfishMagmaRedShock =>
            GetSpriteFromAsset("s_jellyfish_magma_red_shock");
        public static Sprite JellyfishMagmaYellowIdle =>
            GetSpriteFromAsset("s_jellyfish_magma_yellow_idle");
        public static Sprite JellyfishMagmaYellowMove =>
            GetSpriteFromAsset("s_jellyfish_magma_yellow_move");
        public static Sprite JellyfishMagmaYellowShock =>
            GetSpriteFromAsset("s_jellyfish_magma_yellow_shock");
        public static Sprite JellyfishShallowsGreenIdle =>
            GetSpriteFromAsset("s_jellyfish_shallows_green_idle");
        public static Sprite JellyfishShallowsGreenMove =>
            GetSpriteFromAsset("s_jellyfish_shallows_green_move");
        public static Sprite JellyfishShallowsPinkHurt =>
            GetSpriteFromAsset("s_jellyfish_shallows_pink_hurt");
        public static Sprite JellyfishShallowsPinkIdle =>
            GetSpriteFromAsset("s_jellyfish_shallows_pink_idle");
        public static Sprite JellyfishShallowsPinkMove =>
            GetSpriteFromAsset("s_jellyfish_shallows_pink_move");
        public static Sprite JellyfishShallowsYellowIdle =>
            GetSpriteFromAsset("s_jellyfish_shallows_yellow_idle");
        public static Sprite JellyfishShallowsYellowMove =>
            GetSpriteFromAsset("s_jellyfish_shallows_yellow_move");
        public static Sprite JellyfishStore => GetSpriteFromAsset("s_jellyfish_store");
        public static Sprite JellyfishSwampGreenBigIdle =>
            GetSpriteFromAsset("s_jellyfish_swamp_green_big_idle");
        public static Sprite JellyfishSwampGreenBigMove =>
            GetSpriteFromAsset("s_jellyfish_swamp_green_big_move");
        public static Sprite JellyfishSwampGreenSmallIdle =>
            GetSpriteFromAsset("s_jellyfish_swamp_green_small_idle");
        public static Sprite JellyfishSwampGreenSmallMove =>
            GetSpriteFromAsset("s_jellyfish_swamp_green_small_move");
        public static Sprite JellyfishSwampPurpleBigIdle =>
            GetSpriteFromAsset("s_jellyfish_swamp_purple_big_idle");
        public static Sprite JellyfishSwampPurpleBigMove =>
            GetSpriteFromAsset("s_jellyfish_swamp_purple_big_move");
        public static Sprite JellyfishSwampPurpleSmallIdle =>
            GetSpriteFromAsset("s_jellyfish_swamp_purple_small_idle");
        public static Sprite JellyfishSwampPurpleSmallMove =>
            GetSpriteFromAsset("s_jellyfish_swamp_purple_small_move");
        public static Sprite JellyfishSwampYellowBigIdle =>
            GetSpriteFromAsset("s_jellyfish_swamp_yellow_big_idle");
        public static Sprite JellyfishSwampYellowBigMove =>
            GetSpriteFromAsset("s_jellyfish_swamp_yellow_big_move");
        public static Sprite JellyfishSwampYellowSmallIdle =>
            GetSpriteFromAsset("s_jellyfish_swamp_yellow_small_idle");
        public static Sprite JellyfishSwampYellowSmallMove =>
            GetSpriteFromAsset("s_jellyfish_swamp_yellow_small_move");
        public static Sprite JellyfishTransmutatorBroken =>
            GetSpriteFromAsset("s_jellyfish_transmutator_broken");
        public static Sprite JellyfishTransmutatorIdle =>
            GetSpriteFromAsset("s_jellyfish_transmutator_idle");
        public static Sprite JellyfishTransmutatorOn =>
            GetSpriteFromAsset("s_jellyfish_transmutator_on");
        public static Sprite Kelp01 => GetSpriteFromAsset("s_kelp_01");
        public static Sprite Kelp02 => GetSpriteFromAsset("s_kelp_02");
        public static Sprite Kelp03 => GetSpriteFromAsset("s_kelp_03");
        public static Sprite Kelp04 => GetSpriteFromAsset("s_kelp_04");
        public static Sprite Kelp05 => GetSpriteFromAsset("s_kelp_05");
        public static Sprite Kelp06 => GetSpriteFromAsset("s_kelp_06");
        public static Sprite Kelp07 => GetSpriteFromAsset("s_kelp_07");
        public static Sprite Kelp08 => GetSpriteFromAsset("s_kelp_08");
        public static Sprite Kelp09 => GetSpriteFromAsset("s_kelp_09");
        public static Sprite Kelp10 => GetSpriteFromAsset("s_kelp_10");
        public static Sprite Kelp11 => GetSpriteFromAsset("s_kelp_11");
        public static Sprite Kelp12 => GetSpriteFromAsset("s_kelp_12");
        public static Sprite Kelp13 => GetSpriteFromAsset("s_kelp_13");
        public static Sprite Kelp14 => GetSpriteFromAsset("s_kelp_14");
        public static Sprite Kelp15 => GetSpriteFromAsset("s_kelp_15");
        public static Sprite LightControl => GetSpriteFromAsset("s_light_control");
        public static Sprite LightHolder => GetSpriteFromAsset("s_light_holder");
        public static Sprite LightOverlay => GetSpriteFromAsset("s_light_overlay");
        public static Sprite LightRays => GetSpriteFromAsset("s_light_rays");
        public static Sprite MagmaRamp => GetSpriteFromAsset("s_magma_ramp");
        public static Sprite MenuBackground01 => GetSpriteFromAsset("s_menu_background_01");
        public static Sprite MenuBackground02 => GetSpriteFromAsset("s_menu_background_02");
        public static Sprite MenuBackground03 => GetSpriteFromAsset("s_menu_background_03");
        public static Sprite MenuBackground04 => GetSpriteFromAsset("s_menu_background_04");
        public static Sprite MenuBackground05 => GetSpriteFromAsset("s_menu_background_05");
        public static Sprite MenuBackground06Blue =>
            GetSpriteFromAsset("s_menu_background_06_blue");
        public static Sprite MenuBackground06Purple =>
            GetSpriteFromAsset("s_menu_background_06_purple");
        public static Sprite MenuBackground06Red => GetSpriteFromAsset("s_menu_background_06_red");
        public static Sprite MobileBack => GetSpriteFromAsset("s_mobile_back");
        public static Sprite MobileInteractHint => GetSpriteFromAsset("s_mobile_interact_hint");
        public static Sprite MobileInteract => GetSpriteFromAsset("s_mobile_interact");
        public static Sprite MobileStats => GetSpriteFromAsset("s_mobile_stats");
        public static Sprite MobileStickBg => GetSpriteFromAsset("s_mobile_stick_bg");
        public static Sprite MobileStick => GetSpriteFromAsset("s_mobile_stick");
        public static Sprite MoonLight => GetSpriteFromAsset("s_moon_light");
        public static Sprite MushBlock01 => GetSpriteFromAsset("s_mush_block_01");
        public static Sprite MushBlock02 => GetSpriteFromAsset("s_mush_block_02");
        public static Sprite MushBlock03 => GetSpriteFromAsset("s_mush_block_03");
        public static Sprite MushBlockVfx01 => GetSpriteFromAsset("s_mush_block_vfx_01");
        public static Sprite MushBlockVfx02 => GetSpriteFromAsset("s_mush_block_vfx_02");
        public static Sprite Mushroom01 => GetSpriteFromAsset("s_mushroom_01");
        public static Sprite Mushroom02 => GetSpriteFromAsset("s_mushroom_02");
        public static Sprite Mushroom03 => GetSpriteFromAsset("s_mushroom_03");
        public static Sprite Mushroom04 => GetSpriteFromAsset("s_mushroom_04");
        public static Sprite Mushroom05 => GetSpriteFromAsset("s_mushroom_05");
        public static Sprite Mushroom06 => GetSpriteFromAsset("s_mushroom_06");
        public static Sprite Mushroom07 => GetSpriteFromAsset("s_mushroom_07");
        public static Sprite Mushroom08 => GetSpriteFromAsset("s_mushroom_08");
        public static Sprite Mushroom09 => GetSpriteFromAsset("s_mushroom_09");
        public static Sprite Mushroom10 => GetSpriteFromAsset("s_mushroom_10");
        public static Sprite Mushroom11 => GetSpriteFromAsset("s_mushroom_11");
        public static Sprite Mushroom12 => GetSpriteFromAsset("s_mushroom_12");
        public static Sprite Mushroom13 => GetSpriteFromAsset("s_mushroom_13");
        public static Sprite Mushroom14 => GetSpriteFromAsset("s_mushroom_14");
        public static Sprite Mushroom15 => GetSpriteFromAsset("s_mushroom_15");
        public static Sprite Mushroom16 => GetSpriteFromAsset("s_mushroom_16");
        public static Sprite Mushroom17 => GetSpriteFromAsset("s_mushroom_17");
        public static Sprite Mushroom18 => GetSpriteFromAsset("s_mushroom_18");
        public static Sprite Mushroom19 => GetSpriteFromAsset("s_mushroom_19");
        public static Sprite Mushroom20 => GetSpriteFromAsset("s_mushroom_20");
        public static Sprite Mushroom21 => GetSpriteFromAsset("s_mushroom_21");
        public static Sprite Mushroom22 => GetSpriteFromAsset("s_mushroom_22");
        public static Sprite Mushroom23 => GetSpriteFromAsset("s_mushroom_23");
        public static Sprite Mushroom24 => GetSpriteFromAsset("s_mushroom_24");
        public static Sprite Mushroom25 => GetSpriteFromAsset("s_mushroom_25");
        public static Sprite Mushroom26 => GetSpriteFromAsset("s_mushroom_26");
        public static Sprite Mushroom27 => GetSpriteFromAsset("s_mushroom_27");
        public static Sprite Mushroom28 => GetSpriteFromAsset("s_mushroom_28");
        public static Sprite Mushroom29 => GetSpriteFromAsset("s_mushroom_29");
        public static Sprite Mushroom30 => GetSpriteFromAsset("s_mushroom_30");
        public static Sprite Mushroom31 => GetSpriteFromAsset("s_mushroom_31");
        public static Sprite Mushroom32 => GetSpriteFromAsset("s_mushroom_32");
        public static Sprite NewFishAmountBg => GetSpriteFromAsset("s_new_fish_amount_bg");
        public static Sprite Npc01Idle => GetSpriteFromAsset("s_npc_01_idle");
        public static Sprite Npc01Move => GetSpriteFromAsset("s_npc_01_move");
        public static Sprite Npc02Idle => GetSpriteFromAsset("s_npc_02_idle");
        public static Sprite Npc02Move => GetSpriteFromAsset("s_npc_02_move");
        public static Sprite Npc03Idle => GetSpriteFromAsset("s_npc_03_idle");
        public static Sprite Npc03Move => GetSpriteFromAsset("s_npc_03_move");
        public static Sprite Npc04Idle => GetSpriteFromAsset("s_npc_04_idle");
        public static Sprite Npc04Move => GetSpriteFromAsset("s_npc_04_move");
        public static Sprite Npc05Idle => GetSpriteFromAsset("s_npc_05_idle");
        public static Sprite Npc05Move => GetSpriteFromAsset("s_npc_05_move");
        public static Sprite Npc06Idle => GetSpriteFromAsset("s_npc_06_idle");
        public static Sprite Npc06Move => GetSpriteFromAsset("s_npc_06_move");
        public static Sprite Npc07Idle => GetSpriteFromAsset("s_npc_07_idle");
        public static Sprite Npc07Move => GetSpriteFromAsset("s_npc_07_move");
        public static Sprite NpcAbandonedHouse01 => GetSpriteFromAsset("s_npc_abandoned_house_01");
        public static Sprite NpcAbandonedHouse02 => GetSpriteFromAsset("s_npc_abandoned_house_02");
        public static Sprite NpcAbandonedHouse03 => GetSpriteFromAsset("s_npc_abandoned_house_03");
        public static Sprite NpcAlchemistIdle => GetSpriteFromAsset("s_npc_alchemist_idle");
        public static Sprite NpcAlchemistWork => GetSpriteFromAsset("s_npc_alchemist_work");
        public static Sprite NpcArea => GetSpriteFromAsset("s_npc_area");
        public static Sprite NpcBubbleEvil => GetSpriteFromAsset("s_npc_bubble_evil");
        public static Sprite NpcBubbleExclamation => GetSpriteFromAsset("s_npc_bubble_exclamation");
        public static Sprite NpcBubbleHappyQuestion =>
            GetSpriteFromAsset("s_npc_bubble_happy_question");
        public static Sprite NpcBubbleHappy => GetSpriteFromAsset("s_npc_bubble_happy");
        public static Sprite NpcBubbleLove => GetSpriteFromAsset("s_npc_bubble_love");
        public static Sprite NpcBubbleMad => GetSpriteFromAsset("s_npc_bubble_mad");
        public static Sprite NpcBubbleNolove => GetSpriteFromAsset("s_npc_bubble_nolove");
        public static Sprite NpcBubbleQuestion => GetSpriteFromAsset("s_npc_bubble_question");
        public static Sprite NpcBubbleSad => GetSpriteFromAsset("s_npc_bubble_sad");
        public static Sprite NpcBubbleSuperexclamation =>
            GetSpriteFromAsset("s_npc_bubble_superexclamation");
        public static Sprite NpcBubbleSuperlove => GetSpriteFromAsset("s_npc_bubble_superlove");
        public static Sprite NpcBubbleSuperquestion =>
            GetSpriteFromAsset("s_npc_bubble_superquestion");
        public static Sprite NpcBubbleSupersurprised =>
            GetSpriteFromAsset("s_npc_bubble_supersurprised");
        public static Sprite NpcBubbleSurprised => GetSpriteFromAsset("s_npc_bubble_surprised");
        public static Sprite NpcBubbleThinking => GetSpriteFromAsset("s_npc_bubble_thinking");
        public static Sprite NpcBuiltHouse01 => GetSpriteFromAsset("s_npc_built_house_01");
        public static Sprite NpcBuiltHouse02 => GetSpriteFromAsset("s_npc_built_house_02");
        public static Sprite NpcHouse01 => GetSpriteFromAsset("s_npc_house_01");
        public static Sprite NpcHouse02 => GetSpriteFromAsset("s_npc_house_02");
        public static Sprite NpcHouse03 => GetSpriteFromAsset("s_npc_house_03");
        public static Sprite NpcMerchantIdle => GetSpriteFromAsset("s_npc_merchant_idle");
        public static Sprite NpcMerchantIn => GetSpriteFromAsset("s_npc_merchant_in");
        public static Sprite NpcMerchantOut => GetSpriteFromAsset("s_npc_merchant_out");
        public static Sprite NpcMerchantSell => GetSpriteFromAsset("s_npc_merchant_sell");
        public static Sprite NpcTransmutatorIdle => GetSpriteFromAsset("s_npc_transmutator_idle");
        public static Sprite NpcTransmutatorWorking =>
            GetSpriteFromAsset("s_npc_transmutator_working");
        public static Sprite NpcWorkerIdle => GetSpriteFromAsset("s_npc_worker_idle");
        public static Sprite NpcWorkerWorking => GetSpriteFromAsset("s_npc_worker_working");
        public static Sprite ObsidianBlock01 => GetSpriteFromAsset("s_obsidian_block_01");
        public static Sprite ObsidianBlock02 => GetSpriteFromAsset("s_obsidian_block_02");
        public static Sprite ObsidianBlock03 => GetSpriteFromAsset("s_obsidian_block_03");
        public static Sprite ObsidianBlockVfx01 => GetSpriteFromAsset("s_obsidian_block_vfx_01");
        public static Sprite ObsidianBlockVfx02 => GetSpriteFromAsset("s_obsidian_block_vfx_02");
        public static Sprite OceanGlacialBg01 => GetSpriteFromAsset("s_ocean_glacial_bg_01");
        public static Sprite OceanGlacialBg02 => GetSpriteFromAsset("s_ocean_glacial_bg_02");
        public static Sprite OceanGlacialBg03 => GetSpriteFromAsset("s_ocean_glacial_bg_03");
        public static Sprite OceanGlacialBg04 => GetSpriteFromAsset("s_ocean_glacial_bg_04");
        public static Sprite OceanGlacialBg05 => GetSpriteFromAsset("s_ocean_glacial_bg_05");
        public static Sprite OceanMagmaBg01 => GetSpriteFromAsset("s_ocean_magma_bg_01");
        public static Sprite OceanMagmaBg02 => GetSpriteFromAsset("s_ocean_magma_bg_02");
        public static Sprite OceanMagmaBg03 => GetSpriteFromAsset("s_ocean_magma_bg_03");
        public static Sprite OceanMagmaBg04 => GetSpriteFromAsset("s_ocean_magma_bg_04");
        public static Sprite OceanShallowsBg01 => GetSpriteFromAsset("s_ocean_shallows_bg_01");
        public static Sprite OceanShallowsBg02 => GetSpriteFromAsset("s_ocean_shallows_bg_02");
        public static Sprite OceanShallowsBg03 => GetSpriteFromAsset("s_ocean_shallows_bg_03");
        public static Sprite OceanShallowsBg04 => GetSpriteFromAsset("s_ocean_shallows_bg_04");
        public static Sprite OceanShallowsBg05 => GetSpriteFromAsset("s_ocean_shallows_bg_05");
        public static Sprite OceanSwampBg01 => GetSpriteFromAsset("s_ocean_swamp_bg_01");
        public static Sprite OceanSwampBg02 => GetSpriteFromAsset("s_ocean_swamp_bg_02");
        public static Sprite OceanSwampBg03 => GetSpriteFromAsset("s_ocean_swamp_bg_03");
        public static Sprite OceanSwampBg04 => GetSpriteFromAsset("s_ocean_swamp_bg_04");
        public static Sprite OverlayVfx => GetSpriteFromAsset("s_overlay_vfx");
        public static Sprite PlasmaExplosionOverlay =>
            GetSpriteFromAsset("s_plasma_explosion_overlay");
        public static Sprite PlasmaExplosion => GetSpriteFromAsset("s_plasma_explosion");
        public static Sprite PlasmaGun => GetSpriteFromAsset("s_plasma_gun");
        public static Sprite PlasmaLaserLight => GetSpriteFromAsset("s_plasma_laser_light");
        public static Sprite PlasmaLaserVfxLight => GetSpriteFromAsset("s_plasma_laser_vfx_light");
        public static Sprite PlasmaLaserVfx => GetSpriteFromAsset("s_plasma_laser_vfx");
        public static Sprite PlasmaLaser => GetSpriteFromAsset("s_plasma_laser");
        public static Sprite PlasmaLightningLight => GetSpriteFromAsset("s_plasma_lightning_light");
        public static Sprite PlasmaLightning => GetSpriteFromAsset("s_plasma_lightning");
        public static Sprite PlasmaProjectile => GetSpriteFromAsset("s_plasma_projectile");
        public static Sprite Platform01 => GetSpriteFromAsset("s_platform_01");
        public static Sprite PlayerTurtleCrouch => GetSpriteFromAsset("s_player_turtle_crouch");
        public static Sprite PlayerTurtleGroundSleep =>
            GetSpriteFromAsset("s_player_turtle_ground_sleep");
        public static Sprite PlayerTurtleHand => GetSpriteFromAsset("s_player_turtle_hand");
        public static Sprite PlayerTurtleIdleTired =>
            GetSpriteFromAsset("s_player_turtle_idle_tired");
        public static Sprite PlayerTurtleIdle => GetSpriteFromAsset("s_player_turtle_idle");
        public static Sprite PlayerTurtleJumpIn => GetSpriteFromAsset("s_player_turtle_jump_in");
        public static Sprite PlayerTurtleJumpOut => GetSpriteFromAsset("s_player_turtle_jump_out");
        public static Sprite PlayerTurtleJump => GetSpriteFromAsset("s_player_turtle_jump");
        public static Sprite PlayerTurtleJumpsOnBed =>
            GetSpriteFromAsset("s_player_turtle_jumps_on_bed");
        public static Sprite PlayerTurtleMoveTired =>
            GetSpriteFromAsset("s_player_turtle_move_tired");
        public static Sprite PlayerTurtleMove => GetSpriteFromAsset("s_player_turtle_move");
        public static Sprite PlayerTurtleShellphoneIn =>
            GetSpriteFromAsset("s_player_turtle_shellphone_in");
        public static Sprite PlayerTurtleShellphoneOut =>
            GetSpriteFromAsset("s_player_turtle_shellphone_out");
        public static Sprite PlayerTurtleSpawnDebug =>
            GetSpriteFromAsset("s_player_turtle_spawn_debug");
        public static Sprite PlayerTurtleSpawnFixed =>
            GetSpriteFromAsset("s_player_turtle_spawn_fixed");
        public static Sprite PlayerTurtleUnderwaterDead =>
            GetSpriteFromAsset("s_player_turtle_underwater_dead");
        public static Sprite PlayerTurtleUnderwaterHurt =>
            GetSpriteFromAsset("s_player_turtle_underwater_hurt");
        public static Sprite PlayerTurtleUnderwaterIdle =>
            GetSpriteFromAsset("s_player_turtle_underwater_idle");
        public static Sprite PlayerTurtleUnderwaterSwimBack =>
            GetSpriteFromAsset("s_player_turtle_underwater_swim_back");
        public static Sprite PlayerTurtleUnderwaterSwimFront =>
            GetSpriteFromAsset("s_player_turtle_underwater_swim_front");
        public static Sprite PlayerTurtleWave => GetSpriteFromAsset("s_player_turtle_wave");
        public static Sprite Point => GetSpriteFromAsset("s_point");
        public static Sprite PrestigeBg => GetSpriteFromAsset("s_prestige_bg");
        public static Sprite PriceDivider => GetSpriteFromAsset("s_price_divider");
        public static Sprite RegularExplosion => GetSpriteFromAsset("s_regular_explosion");
        public static Sprite RegularLight => GetSpriteFromAsset("s_regular_light");
        public static Sprite ReloadUiBg => GetSpriteFromAsset("s_reload_ui_bg");
        public static Sprite ReloadUiProgress => GetSpriteFromAsset("s_reload_ui_progress");
        public static Sprite ResourceArea => GetSpriteFromAsset("s_resource_area");
        public static Sprite ResourceHitVfx01 => GetSpriteFromAsset("s_resource_hit_vfx_01");
        public static Sprite ResultDivider => GetSpriteFromAsset("s_result_divider");
        public static Sprite RobotAttack => GetSpriteFromAsset("s_robot_attack");
        public static Sprite RobotIdle => GetSpriteFromAsset("s_robot_idle");
        public static Sprite RobotProjectile => GetSpriteFromAsset("s_robot_projectile");
        public static Sprite Rock01 => GetSpriteFromAsset("s_rock_01");
        public static Sprite Rock02 => GetSpriteFromAsset("s_rock_02");
        public static Sprite Rock03 => GetSpriteFromAsset("s_rock_03");
        public static Sprite Rock04 => GetSpriteFromAsset("s_rock_04");
        public static Sprite RoomBorder => GetSpriteFromAsset("s_room_border");
        public static Sprite Room => GetSpriteFromAsset("s_room");
        public static Sprite ScrapBlock01 => GetSpriteFromAsset("s_scrap_block_01");
        public static Sprite ScrapBlock02 => GetSpriteFromAsset("s_scrap_block_02");
        public static Sprite ScrapBlock03 => GetSpriteFromAsset("s_scrap_block_03");
        public static Sprite ScrapBlockVfx01 => GetSpriteFromAsset("s_scrap_block_vfx_01");
        public static Sprite ScrapBlockVfx02 => GetSpriteFromAsset("s_scrap_block_vfx_02");
        public static Sprite Seedling01 => GetSpriteFromAsset("s_seedling_01");
        public static Sprite Seedling02 => GetSpriteFromAsset("s_seedling_02");
        public static Sprite Seedling03 => GetSpriteFromAsset("s_seedling_03");
        public static Sprite Seedling04 => GetSpriteFromAsset("s_seedling_04");
        public static Sprite Seedling05 => GetSpriteFromAsset("s_seedling_05");
        public static Sprite SelectedArrow => GetSpriteFromAsset("s_selected_arrow");
        public static Sprite ShallowsRamp => GetSpriteFromAsset("s_shallows_ramp");
        public static Sprite ShellVfx => GetSpriteFromAsset("s_shell_vfx");
        public static Sprite SilverRamp => GetSpriteFromAsset("s_silver_ramp");
        public static Sprite SkillAgileHands01 => GetSpriteFromAsset("s_skill_agile_hands_01");
        public static Sprite SkillAgileHands10 => GetSpriteFromAsset("s_skill_agile_hands_10");
        public static Sprite SkillAlchemyStationDoubleChance01 =>
            GetSpriteFromAsset("s_skill_alchemy_station_double_chance_01");
        public static Sprite SkillAlchemyStationDoubleChance02 =>
            GetSpriteFromAsset("s_skill_alchemy_station_double_chance_02");
        public static Sprite SkillAlchemyStationSpeed01 =>
            GetSpriteFromAsset("s_skill_alchemy_station_speed_01");
        public static Sprite SkillAlchemyStationSpeed02 =>
            GetSpriteFromAsset("s_skill_alchemy_station_speed_02");
        public static Sprite SkillAlchemyStation => GetSpriteFromAsset("s_skill_alchemy_station");
        public static Sprite SkillArrowAll => GetSpriteFromAsset("s_skill_arrow_all");
        public static Sprite SkillArrowAny => GetSpriteFromAsset("s_skill_arrow_any");
        public static Sprite SkillAutoOutputSpeed01 =>
            GetSpriteFromAsset("s_skill_auto_output_speed_01");
        public static Sprite SkillAutoOutputSpeed10 =>
            GetSpriteFromAsset("s_skill_auto_output_speed_10");
        public static Sprite SkillBackgroundLight => GetSpriteFromAsset("s_skill_background_light");
        public static Sprite SkillBackground => GetSpriteFromAsset("s_skill_background");
        public static Sprite SkillBiodiversity01 => GetSpriteFromAsset("s_skill_biodiversity_01");
        public static Sprite SkillBiodiversity02 => GetSpriteFromAsset("s_skill_biodiversity_02");
        public static Sprite SkillBiodiversity03 => GetSpriteFromAsset("s_skill_biodiversity_03");
        public static Sprite SkillBiodiversity04 => GetSpriteFromAsset("s_skill_biodiversity_04");
        public static Sprite SkillBiovalue01 => GetSpriteFromAsset("s_skill_biovalue_01");
        public static Sprite SkillBiovalueAmount01 =>
            GetSpriteFromAsset("s_skill_biovalue_amount_01");
        public static Sprite SkillBiovalueAmount02 =>
            GetSpriteFromAsset("s_skill_biovalue_amount_02");
        public static Sprite SkillBiovalueAmount10 =>
            GetSpriteFromAsset("s_skill_biovalue_amount_10");
        public static Sprite SkillBiovalueGolden => GetSpriteFromAsset("s_skill_biovalue_golden");
        public static Sprite SkillBiovalueRainbow => GetSpriteFromAsset("s_skill_biovalue_rainbow");
        public static Sprite SkillBiovalueSilver => GetSpriteFromAsset("s_skill_biovalue_silver");
        public static Sprite SkillBubbleCapacity01 =>
            GetSpriteFromAsset("s_skill_bubble_capacity_01");
        public static Sprite SkillBubbleCapacity02 =>
            GetSpriteFromAsset("s_skill_bubble_capacity_02");
        public static Sprite SkillBubbleCapacity03 =>
            GetSpriteFromAsset("s_skill_bubble_capacity_03");
        public static Sprite SkillBubbleCapacity04 =>
            GetSpriteFromAsset("s_skill_bubble_capacity_04");
        public static Sprite SkillBubbleCriticalChance01 =>
            GetSpriteFromAsset("s_skill_bubble_critical_chance_01");
        public static Sprite SkillBubbleCriticalChance02 =>
            GetSpriteFromAsset("s_skill_bubble_critical_chance_02");
        public static Sprite SkillBubbleCriticalChance03 =>
            GetSpriteFromAsset("s_skill_bubble_critical_chance_03");
        public static Sprite SkillBubbleCriticalDamage01 =>
            GetSpriteFromAsset("s_skill_bubble_critical_damage_01");
        public static Sprite SkillBubbleCriticalDamage02 =>
            GetSpriteFromAsset("s_skill_bubble_critical_damage_02");
        public static Sprite SkillBubbleCriticalDamage03 =>
            GetSpriteFromAsset("s_skill_bubble_critical_damage_03");
        public static Sprite SkillBubbleDamage01 => GetSpriteFromAsset("s_skill_bubble_damage_01");
        public static Sprite SkillBubbleDamage02 => GetSpriteFromAsset("s_skill_bubble_damage_02");
        public static Sprite SkillBubbleDamage03 => GetSpriteFromAsset("s_skill_bubble_damage_03");
        public static Sprite SkillBubbleDamage04 => GetSpriteFromAsset("s_skill_bubble_damage_04");
        public static Sprite SkillBubbleDamage05 => GetSpriteFromAsset("s_skill_bubble_damage_05");
        public static Sprite SkillBubbleDamage06 => GetSpriteFromAsset("s_skill_bubble_damage_06");
        public static Sprite SkillBubbleDamage07 => GetSpriteFromAsset("s_skill_bubble_damage_07");
        public static Sprite SkillBubbleDamage08 => GetSpriteFromAsset("s_skill_bubble_damage_08");
        public static Sprite SkillBubbleDamage09 => GetSpriteFromAsset("s_skill_bubble_damage_09");
        public static Sprite SkillBubbleDamage10 => GetSpriteFromAsset("s_skill_bubble_damage_10");
        public static Sprite SkillBubbleDoppel01 => GetSpriteFromAsset("s_skill_bubble_doppel_01");
        public static Sprite SkillBubbleDoppel02 => GetSpriteFromAsset("s_skill_bubble_doppel_02");
        public static Sprite SkillBubbleDoppel03 => GetSpriteFromAsset("s_skill_bubble_doppel_03");
        public static Sprite SkillBubbleDuration => GetSpriteFromAsset("s_skill_bubble_duration");
        public static Sprite SkillBubbleExecute01 =>
            GetSpriteFromAsset("s_skill_bubble_execute_01");
        public static Sprite SkillBubbleExecute02 =>
            GetSpriteFromAsset("s_skill_bubble_execute_02");
        public static Sprite SkillBubbleFirerate01 =>
            GetSpriteFromAsset("s_skill_bubble_firerate_01");
        public static Sprite SkillBubbleFirerate02 =>
            GetSpriteFromAsset("s_skill_bubble_firerate_02");
        public static Sprite SkillBubbleFirerate03 =>
            GetSpriteFromAsset("s_skill_bubble_firerate_03");
        public static Sprite SkillBubbleOxygenDamage =>
            GetSpriteFromAsset("s_skill_bubble_oxygen_damage");
        public static Sprite SkillBubblePenetration01 =>
            GetSpriteFromAsset("s_skill_bubble_penetration_01");
        public static Sprite SkillBubblePenetration02 =>
            GetSpriteFromAsset("s_skill_bubble_penetration_02");
        public static Sprite SkillBubbleReload01 => GetSpriteFromAsset("s_skill_bubble_reload_01");
        public static Sprite SkillBubbleReload02 => GetSpriteFromAsset("s_skill_bubble_reload_02");
        public static Sprite SkillBubbleReload03 => GetSpriteFromAsset("s_skill_bubble_reload_03");
        public static Sprite SkillBubbleSize01 => GetSpriteFromAsset("s_skill_bubble_size_01");
        public static Sprite SkillBubbleSize02 => GetSpriteFromAsset("s_skill_bubble_size_02");
        public static Sprite SkillBubbleSize03 => GetSpriteFromAsset("s_skill_bubble_size_03");
        public static Sprite SkillBubbleSmite01 => GetSpriteFromAsset("s_skill_bubble_smite_01");
        public static Sprite SkillBubbleSmite02 => GetSpriteFromAsset("s_skill_bubble_smite_02");
        public static Sprite SkillBubbleSmite03 => GetSpriteFromAsset("s_skill_bubble_smite_03");
        public static Sprite SkillBubbleSmiteThreshold01 =>
            GetSpriteFromAsset("s_skill_bubble_smite_threshold_01");
        public static Sprite SkillBubbleSpeed01 => GetSpriteFromAsset("s_skill_bubble_speed_01");
        public static Sprite SkillBubbleSpeed02 => GetSpriteFromAsset("s_skill_bubble_speed_02");
        public static Sprite SkillBubbleStrike01 => GetSpriteFromAsset("s_skill_bubble_strike_01");
        public static Sprite SkillBubbleStrike02 => GetSpriteFromAsset("s_skill_bubble_strike_02");
        public static Sprite SkillBubbleStrike03 => GetSpriteFromAsset("s_skill_bubble_strike_03");
        public static Sprite SkillBubbleTank01 => GetSpriteFromAsset("s_skill_bubble_tank_01");
        public static Sprite SkillBubbleTank02 => GetSpriteFromAsset("s_skill_bubble_tank_02");
        public static Sprite SkillBubbleTank03 => GetSpriteFromAsset("s_skill_bubble_tank_03");
        public static Sprite SkillBubbleTank04 => GetSpriteFromAsset("s_skill_bubble_tank_04");
        public static Sprite SkillChainBubbleChance01 =>
            GetSpriteFromAsset("s_skill_chain_bubble_chance_01");
        public static Sprite SkillChainBubbleChance02 =>
            GetSpriteFromAsset("s_skill_chain_bubble_chance_02");
        public static Sprite SkillChainBubbleNumber01 =>
            GetSpriteFromAsset("s_skill_chain_bubble_number_01");
        public static Sprite SkillChainBubbleNumber02 =>
            GetSpriteFromAsset("s_skill_chain_bubble_number_02");
        public static Sprite SkillChestSpeed01 => GetSpriteFromAsset("s_skill_chest_speed_01");
        public static Sprite SkillChestSpeed02 => GetSpriteFromAsset("s_skill_chest_speed_02");
        public static Sprite SkillCrystalFinal => GetSpriteFromAsset("s_skill_crystal_final");
        public static Sprite SkillCrystalIncrease => GetSpriteFromAsset("s_skill_crystal_increase");
        public static Sprite SkillCrystalValueRare =>
            GetSpriteFromAsset("s_skill_crystal_value_rare");
        public static Sprite SkillCrystalValue => GetSpriteFromAsset("s_skill_crystal_value");
        public static Sprite SkillDeepBreath => GetSpriteFromAsset("s_skill_deep_breath");
        public static Sprite SkillDescriptionBg => GetSpriteFromAsset("s_skill_description_bg");
        public static Sprite SkillDoublePlasma => GetSpriteFromAsset("s_skill_double_plasma");
        public static Sprite SkillEntityArrival01 =>
            GetSpriteFromAsset("s_skill_entity_arrival_01");
        public static Sprite SkillEntityArrival02 =>
            GetSpriteFromAsset("s_skill_entity_arrival_02");
        public static Sprite SkillExpeditionDemand01 =>
            GetSpriteFromAsset("s_skill_expedition_demand_01");
        public static Sprite SkillFlaskFinal => GetSpriteFromAsset("s_skill_flask_final");
        public static Sprite SkillFriendlyBubbleChance01 =>
            GetSpriteFromAsset("s_skill_friendly_bubble_chance_01");
        public static Sprite SkillFriendlyBubbleChance02 =>
            GetSpriteFromAsset("s_skill_friendly_bubble_chance_02");
        public static Sprite SkillFriendlyBubbleDamage01 =>
            GetSpriteFromAsset("s_skill_friendly_bubble_damage_01");
        public static Sprite SkillFriendlyBubbleDamage02 =>
            GetSpriteFromAsset("s_skill_friendly_bubble_damage_02");
        public static Sprite SkillFriendlyBubbleDamage03 =>
            GetSpriteFromAsset("s_skill_friendly_bubble_damage_03");
        public static Sprite SkillFriendlyBubbleSize01 =>
            GetSpriteFromAsset("s_skill_friendly_bubble_size_01");
        public static Sprite SkillFriendlyBubbleSize02 =>
            GetSpriteFromAsset("s_skill_friendly_bubble_size_02");
        public static Sprite SkillGlobalChest => GetSpriteFromAsset("s_skill_global_chest");
        public static Sprite SkillHammock02 => GetSpriteFromAsset("s_skill_hammock_02");
        public static Sprite SkillHammockOld01 => GetSpriteFromAsset("s_skill_hammock_old_01");
        public static Sprite SkillHammock => GetSpriteFromAsset("s_skill_hammock");
        public static Sprite SkillHomingBubbles => GetSpriteFromAsset("s_skill_homing_bubbles");
        public static Sprite SkillJellyfishInsurance01 =>
            GetSpriteFromAsset("s_skill_jellyfish_insurance_01");
        public static Sprite SkillJellyfishInsurance02 =>
            GetSpriteFromAsset("s_skill_jellyfish_insurance_02");
        public static Sprite SkillJellyfishInsurance03 =>
            GetSpriteFromAsset("s_skill_jellyfish_insurance_03");
        public static Sprite SkillJellyfishOxygen => GetSpriteFromAsset("s_skill_jellyfish_oxygen");
        public static Sprite SkillJellyfishTransmutator =>
            GetSpriteFromAsset("s_skill_jellyfish_transmutator");
        public static Sprite SkillJellyfishValue01 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_01");
        public static Sprite SkillJellyfishValue02 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_02");
        public static Sprite SkillJellyfishValue03 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_03");
        public static Sprite SkillJellyfishValue04 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_04");
        public static Sprite SkillJellyfishValue05 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_05");
        public static Sprite SkillJellyfishValue06 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_06");
        public static Sprite SkillJellyfishValue07 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_07");
        public static Sprite SkillJellyfishValue08 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_08");
        public static Sprite SkillJellyfishValue09 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_09");
        public static Sprite SkillJellyfishValue10 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_10");
        public static Sprite SkillJellyfishValueRare01 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_rare_01");
        public static Sprite SkillJellyfishValueRare02 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_rare_02");
        public static Sprite SkillJellyfishValueRare03 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_rare_03");
        public static Sprite SkillJellyfishValueRare04 =>
            GetSpriteFromAsset("s_skill_jellyfish_value_rare_04");
        public static Sprite SkillLineDotted => GetSpriteFromAsset("s_skill_line_dotted");
        public static Sprite SkillLineLight => GetSpriteFromAsset("s_skill_line_light");
        public static Sprite SkillLine => GetSpriteFromAsset("s_skill_line");
        public static Sprite SkillLockCollectableUi =>
            GetSpriteFromAsset("s_skill_lock_collectable_ui");
        public static Sprite SkillLockDemo => GetSpriteFromAsset("s_skill_lock_demo");
        public static Sprite SkillMovementSpeed01 =>
            GetSpriteFromAsset("s_skill_movement_speed_01");
        public static Sprite SkillMovementSpeed02 =>
            GetSpriteFromAsset("s_skill_movement_speed_02");
        public static Sprite SkillMovementSpeed03 =>
            GetSpriteFromAsset("s_skill_movement_speed_03");
        public static Sprite SkillMultReload => GetSpriteFromAsset("s_skill_mult_reload");
        public static Sprite SkillMushroomFinal => GetSpriteFromAsset("s_skill_mushroom_final");
        public static Sprite SkillMushroomIncrease =>
            GetSpriteFromAsset("s_skill_mushroom_increase");
        public static Sprite SkillMushroomValueRare =>
            GetSpriteFromAsset("s_skill_mushroom_value_rare");
        public static Sprite SkillMushroomValue => GetSpriteFromAsset("s_skill_mushroom_value");
        public static Sprite SkillObsidianFinal => GetSpriteFromAsset("s_skill_obsidian_final");
        public static Sprite SkillObsidianIncrease =>
            GetSpriteFromAsset("s_skill_obsidian_increase");
        public static Sprite SkillObsidianValueRare =>
            GetSpriteFromAsset("s_skill_obsidian_value_rare");
        public static Sprite SkillObsidianValue => GetSpriteFromAsset("s_skill_obsidian_value");
        public static Sprite SkillOverheatDamage01 =>
            GetSpriteFromAsset("s_skill_overheat_damage_01");
        public static Sprite SkillOverheatDamage10 =>
            GetSpriteFromAsset("s_skill_overheat_damage_10");
        public static Sprite SkillOverheatSpeed01 =>
            GetSpriteFromAsset("s_skill_overheat_speed_01");
        public static Sprite SkillOxygenCatch01 => GetSpriteFromAsset("s_skill_oxygen_catch_01");
        public static Sprite SkillOxygenCatch02 => GetSpriteFromAsset("s_skill_oxygen_catch_02");
        public static Sprite SkillOxygenExtraTank01 =>
            GetSpriteFromAsset("s_skill_oxygen_extra_tank_01");
        public static Sprite SkillOxygenExtraTank10 =>
            GetSpriteFromAsset("s_skill_oxygen_extra_tank_10");
        public static Sprite SkillOxygenRegen01 => GetSpriteFromAsset("s_skill_oxygen_regen_01");
        public static Sprite SkillOxygenRegen02 => GetSpriteFromAsset("s_skill_oxygen_regen_02");
        public static Sprite SkillOxygenRegen03 => GetSpriteFromAsset("s_skill_oxygen_regen_03");
        public static Sprite SkillOxygenRegenSpeed01 =>
            GetSpriteFromAsset("s_skill_oxygen_regen_speed_01");
        public static Sprite SkillOxygenRegenSpeed02 =>
            GetSpriteFromAsset("s_skill_oxygen_regen_speed_02");
        public static Sprite SkillOxygenRegenSpeed03 =>
            GetSpriteFromAsset("s_skill_oxygen_regen_speed_03");
        public static Sprite SkillOxygenTank01 => GetSpriteFromAsset("s_skill_oxygen_tank_01");
        public static Sprite SkillOxygenTank02 => GetSpriteFromAsset("s_skill_oxygen_tank_02");
        public static Sprite SkillOxygenTank03 => GetSpriteFromAsset("s_skill_oxygen_tank_03");
        public static Sprite SkillOxygenTank04 => GetSpriteFromAsset("s_skill_oxygen_tank_04");
        public static Sprite SkillOxygenTank05 => GetSpriteFromAsset("s_skill_oxygen_tank_05");
        public static Sprite SkillOxygenTank06 => GetSpriteFromAsset("s_skill_oxygen_tank_06");
        public static Sprite SkillOxygenTank07 => GetSpriteFromAsset("s_skill_oxygen_tank_07");
        public static Sprite SkillOxygenTank08 => GetSpriteFromAsset("s_skill_oxygen_tank_08");
        public static Sprite SkillOxygenTank09 => GetSpriteFromAsset("s_skill_oxygen_tank_09");
        public static Sprite SkillOxygenTank10 => GetSpriteFromAsset("s_skill_oxygen_tank_10");
        public static Sprite SkillPickupRange01 => GetSpriteFromAsset("s_skill_pickup_range_01");
        public static Sprite SkillPickupRange02 => GetSpriteFromAsset("s_skill_pickup_range_02");
        public static Sprite SkillPickupRange03 => GetSpriteFromAsset("s_skill_pickup_range_03");
        public static Sprite SkillPickupRange10 => GetSpriteFromAsset("s_skill_pickup_range_10");
        public static Sprite SkillPlasmaCapacity01 =>
            GetSpriteFromAsset("s_skill_plasma_capacity_01");
        public static Sprite SkillPlasmaCapacity02 =>
            GetSpriteFromAsset("s_skill_plasma_capacity_02");
        public static Sprite SkillPlasmaCapacity03 =>
            GetSpriteFromAsset("s_skill_plasma_capacity_03");
        public static Sprite SkillPlasmaCapacity04 =>
            GetSpriteFromAsset("s_skill_plasma_capacity_04");
        public static Sprite SkillPlasmaChainDamage01 =>
            GetSpriteFromAsset("s_skill_plasma_chain_damage_01");
        public static Sprite SkillPlasmaChainDamage02 =>
            GetSpriteFromAsset("s_skill_plasma_chain_damage_02");
        public static Sprite SkillPlasmaChainDamage03 =>
            GetSpriteFromAsset("s_skill_plasma_chain_damage_03");
        public static Sprite SkillPlasmaChainDamage04 =>
            GetSpriteFromAsset("s_skill_plasma_chain_damage_04");
        public static Sprite SkillPlasmaChainFurtherDamage =>
            GetSpriteFromAsset("s_skill_plasma_chain_further_damage");
        public static Sprite SkillPlasmaChainNumber01 =>
            GetSpriteFromAsset("s_skill_plasma_chain_number_01");
        public static Sprite SkillPlasmaChainNumber02 =>
            GetSpriteFromAsset("s_skill_plasma_chain_number_02");
        public static Sprite SkillPlasmaChainNumber03 =>
            GetSpriteFromAsset("s_skill_plasma_chain_number_03");
        public static Sprite SkillPlasmaCharge01 => GetSpriteFromAsset("s_skill_plasma_charge_01");
        public static Sprite SkillPlasmaCharge02 => GetSpriteFromAsset("s_skill_plasma_charge_02");
        public static Sprite SkillPlasmaCharge03 => GetSpriteFromAsset("s_skill_plasma_charge_03");
        public static Sprite SkillPlasmaDamage01 => GetSpriteFromAsset("s_skill_plasma_damage_01");
        public static Sprite SkillPlasmaDamage02 => GetSpriteFromAsset("s_skill_plasma_damage_02");
        public static Sprite SkillPlasmaDamage03 => GetSpriteFromAsset("s_skill_plasma_damage_03");
        public static Sprite SkillPlasmaDamage04 => GetSpriteFromAsset("s_skill_plasma_damage_04");
        public static Sprite SkillPlasmaDamage05 => GetSpriteFromAsset("s_skill_plasma_damage_05");
        public static Sprite SkillPlasmaDamage06 => GetSpriteFromAsset("s_skill_plasma_damage_06");
        public static Sprite SkillPlasmaDamage07 => GetSpriteFromAsset("s_skill_plasma_damage_07");
        public static Sprite SkillPlasmaDamage08 => GetSpriteFromAsset("s_skill_plasma_damage_08");
        public static Sprite SkillPlasmaDamage09 => GetSpriteFromAsset("s_skill_plasma_damage_09");
        public static Sprite SkillPlasmaDamage10 => GetSpriteFromAsset("s_skill_plasma_damage_10");
        public static Sprite SkillPlasmaExplosionChance01 =>
            GetSpriteFromAsset("s_skill_plasma_explosion_chance_01");
        public static Sprite SkillPlasmaExplosionChance02 =>
            GetSpriteFromAsset("s_skill_plasma_explosion_chance_02");
        public static Sprite SkillPlasmaExplosionDamage01 =>
            GetSpriteFromAsset("s_skill_plasma_explosion_damage_01");
        public static Sprite SkillPlasmaExplosionDamage02 =>
            GetSpriteFromAsset("s_skill_plasma_explosion_damage_02");
        public static Sprite SkillPlasmaExplosionRange01 =>
            GetSpriteFromAsset("s_skill_plasma_explosion_range_01");
        public static Sprite SkillPlasmaFirerate01 =>
            GetSpriteFromAsset("s_skill_plasma_firerate_01");
        public static Sprite SkillPlasmaFirerate02 =>
            GetSpriteFromAsset("s_skill_plasma_firerate_02");
        public static Sprite SkillPlasmaFirerate03 =>
            GetSpriteFromAsset("s_skill_plasma_firerate_03");
        public static Sprite SkillPlasmaLightningChance01 =>
            GetSpriteFromAsset("s_skill_plasma_lightning_chance_01");
        public static Sprite SkillPlasmaLightningChance02 =>
            GetSpriteFromAsset("s_skill_plasma_lightning_chance_02");
        public static Sprite SkillPlasmaLightningDamage01 =>
            GetSpriteFromAsset("s_skill_plasma_lightning_damage_01");
        public static Sprite SkillPlasmaLightningDamage02 =>
            GetSpriteFromAsset("s_skill_plasma_lightning_damage_02");
        public static Sprite SkillPlasmaLightningRange =>
            GetSpriteFromAsset("s_skill_plasma_lightning_range");
        public static Sprite SkillPlasmaOxygenDamage =>
            GetSpriteFromAsset("s_skill_plasma_oxygen_damage");
        public static Sprite SkillPlasmaRange01 => GetSpriteFromAsset("s_skill_plasma_range_01");
        public static Sprite SkillPlasmaRange02 => GetSpriteFromAsset("s_skill_plasma_range_02");
        public static Sprite SkillPlasmaRange03 => GetSpriteFromAsset("s_skill_plasma_range_03");
        public static Sprite SkillPlasmaRange04 => GetSpriteFromAsset("s_skill_plasma_range_04");
        public static Sprite SkillPlasmaReload01 => GetSpriteFromAsset("s_skill_plasma_reload_01");
        public static Sprite SkillPlasmaReload02 => GetSpriteFromAsset("s_skill_plasma_reload_02");
        public static Sprite SkillPlasmaReload03 => GetSpriteFromAsset("s_skill_plasma_reload_03");
        public static Sprite SkillPlasmaTank01 => GetSpriteFromAsset("s_skill_plasma_tank_01");
        public static Sprite SkillPlasmaTank02 => GetSpriteFromAsset("s_skill_plasma_tank_02");
        public static Sprite SkillPlasmaTank03 => GetSpriteFromAsset("s_skill_plasma_tank_03");
        public static Sprite SkillPlasmaTank04 => GetSpriteFromAsset("s_skill_plasma_tank_04");
        public static Sprite SkillPlasmaTool => GetSpriteFromAsset("s_skill_plasma_tool");
        public static Sprite SkillPlayerShellphone =>
            GetSpriteFromAsset("s_skill_player_shellphone");
        public static Sprite SkillPlayerSlotCapacity01 =>
            GetSpriteFromAsset("s_skill_player_slot_capacity_01");
        public static Sprite SkillPlayerSlotCapacity02 =>
            GetSpriteFromAsset("s_skill_player_slot_capacity_02");
        public static Sprite SkillPlayerSlotCapacity03 =>
            GetSpriteFromAsset("s_skill_player_slot_capacity_03");
        public static Sprite SkillPlayerSlotCapacity04 =>
            GetSpriteFromAsset("s_skill_player_slot_capacity_04");
        public static Sprite SkillPlayerSlotCapacity05 =>
            GetSpriteFromAsset("s_skill_player_slot_capacity_05");
        public static Sprite SkillPlayerSlots01 => GetSpriteFromAsset("s_skill_player_slots_01");
        public static Sprite SkillPlayerSlots02 => GetSpriteFromAsset("s_skill_player_slots_02");
        public static Sprite SkillPlayerSlots03 => GetSpriteFromAsset("s_skill_player_slots_03");
        public static Sprite SkillPlayerSlots04 => GetSpriteFromAsset("s_skill_player_slots_04");
        public static Sprite SkillPlayerSlots05 => GetSpriteFromAsset("s_skill_player_slots_05");
        public static Sprite SkillResourceOxygen => GetSpriteFromAsset("s_skill_resource_oxygen");
        public static Sprite SkillRobotDamage01 => GetSpriteFromAsset("s_skill_robot_damage_01");
        public static Sprite SkillRobotFirerare02 =>
            GetSpriteFromAsset("s_skill_robot_firerare_02");
        public static Sprite SkillRobotFirerate01 =>
            GetSpriteFromAsset("s_skill_robot_firerate_01");
        public static Sprite SkillRobotFirerate03 =>
            GetSpriteFromAsset("s_skill_robot_firerate_03");
        public static Sprite SkillRobotLightning => GetSpriteFromAsset("s_skill_robot_lightning");
        public static Sprite SkillRobotNumber01 => GetSpriteFromAsset("s_skill_robot_number_01");
        public static Sprite SkillScrapFinal => GetSpriteFromAsset("s_skill_scrap_final");
        public static Sprite SkillScrapIncrease => GetSpriteFromAsset("s_skill_scrap_increase");
        public static Sprite SkillScrapValueRare => GetSpriteFromAsset("s_skill_scrap_value_rare");
        public static Sprite SkillScrapValue => GetSpriteFromAsset("s_skill_scrap_value");
        public static Sprite SkillShockFrequency => GetSpriteFromAsset("s_skill_shock_frequency");
        public static Sprite SkillShockResistance01 =>
            GetSpriteFromAsset("s_skill_shock_resistance_01");
        public static Sprite SkillShockResistance10 =>
            GetSpriteFromAsset("s_skill_shock_resistance_10");
        public static Sprite SkillStarfishDamage01 =>
            GetSpriteFromAsset("s_skill_starfish_damage_01");
        public static Sprite SkillStarfishDamage02 =>
            GetSpriteFromAsset("s_skill_starfish_damage_02");
        public static Sprite SkillStarfishFirerate01 =>
            GetSpriteFromAsset("s_skill_starfish_firerate_01");
        public static Sprite SkillStarfishFirerate02 =>
            GetSpriteFromAsset("s_skill_starfish_firerate_02");
        public static Sprite SkillStarfishNumber01 =>
            GetSpriteFromAsset("s_skill_starfish_number_01");
        public static Sprite SkillStarfishNumber02 =>
            GetSpriteFromAsset("s_skill_starfish_number_02");
        public static Sprite SkillStorageAutoOutput =>
            GetSpriteFromAsset("s_skill_storage_auto_output");
        public static Sprite SkillStorageSlots01 => GetSpriteFromAsset("s_skill_storage_slots_01");
        public static Sprite SkillStorageSlots02 => GetSpriteFromAsset("s_skill_storage_slots_02");
        public static Sprite SkillStoreExtraSell => GetSpriteFromAsset("s_skill_store_extra_sell");
        public static Sprite SkillStoreSlotCapacity01 =>
            GetSpriteFromAsset("s_skill_store_slot_capacity_01");
        public static Sprite SkillStoreSlotCapacity02 =>
            GetSpriteFromAsset("s_skill_store_slot_capacity_02");
        public static Sprite SkillStoreSlotCapacity03 =>
            GetSpriteFromAsset("s_skill_store_slot_capacity_03");
        public static Sprite SkillStoreSlotCapacity04 =>
            GetSpriteFromAsset("s_skill_store_slot_capacity_04");
        public static Sprite SkillStoreSlotCapacity05 =>
            GetSpriteFromAsset("s_skill_store_slot_capacity_05");
        public static Sprite SkillStoreSlots01 => GetSpriteFromAsset("s_skill_store_slots_01");
        public static Sprite SkillStoreSlots02 => GetSpriteFromAsset("s_skill_store_slots_02");
        public static Sprite SkillStoreSlots03 => GetSpriteFromAsset("s_skill_store_slots_03");
        public static Sprite SkillStoreSlots04 => GetSpriteFromAsset("s_skill_store_slots_04");
        public static Sprite SkillStoreSlots05 => GetSpriteFromAsset("s_skill_store_slots_05");
        public static Sprite SkillStoreSpeed01 => GetSpriteFromAsset("s_skill_store_speed_01");
        public static Sprite SkillStoreSpeed02 => GetSpriteFromAsset("s_skill_store_speed_02");
        public static Sprite SkillStoreSpeed03 => GetSpriteFromAsset("s_skill_store_speed_03");
        public static Sprite SkillStoreSpeed04 => GetSpriteFromAsset("s_skill_store_speed_04");
        public static Sprite SkillStoreSpeed05 => GetSpriteFromAsset("s_skill_store_speed_05");
        public static Sprite SkillStoreSpeed06 => GetSpriteFromAsset("s_skill_store_speed_06");
        public static Sprite SkillStoreSpeed07 => GetSpriteFromAsset("s_skill_store_speed_07");
        public static Sprite SkillStoreSpeed08 => GetSpriteFromAsset("s_skill_store_speed_08");
        public static Sprite SkillStoreSpeed09 => GetSpriteFromAsset("s_skill_store_speed_09");
        public static Sprite SkillStoreSpeed10 => GetSpriteFromAsset("s_skill_store_speed_10");
        public static Sprite SkillStoreTransmutate01 =>
            GetSpriteFromAsset("s_skill_store_transmutate_01");
        public static Sprite SkillSubmarineRecoverPlus =>
            GetSpriteFromAsset("s_skill_submarine_recover_plus");
        public static Sprite SkillSubmarineRecover =>
            GetSpriteFromAsset("s_skill_submarine_recover");
        public static Sprite SkillSubmarineStorage =>
            GetSpriteFromAsset("s_skill_submarine_storage");
        public static Sprite SkillSubmarine => GetSpriteFromAsset("s_skill_submarine");
        public static Sprite SkillTransmutatorAutoOutput =>
            GetSpriteFromAsset("s_skill_transmutator_auto_output");
        public static Sprite SkillTransmutatorEmerald =>
            GetSpriteFromAsset("s_skill_transmutator_emerald");
        public static Sprite SkillTransmutatorGolden =>
            GetSpriteFromAsset("s_skill_transmutator_golden");
        public static Sprite SkillTransmutatorSell01 =>
            GetSpriteFromAsset("s_skill_transmutator_sell_01");
        public static Sprite SkillTransmutatorSlots01 =>
            GetSpriteFromAsset("s_skill_transmutator_slots_01");
        public static Sprite SkillTransmutatorSlots02 =>
            GetSpriteFromAsset("s_skill_transmutator_slots_02");
        public static Sprite SkillTransmutatorSpeed01 =>
            GetSpriteFromAsset("s_skill_transmutator_speed_01");
        public static Sprite SkillTransmutatorSpeed02 =>
            GetSpriteFromAsset("s_skill_transmutator_speed_02");
        public static Sprite SkillTransmutatorSpeed03 =>
            GetSpriteFromAsset("s_skill_transmutator_speed_03");
        public static Sprite SkillTreeBgTexture => GetSpriteFromAsset("s_skill_tree_bg_texture");
        public static Sprite SkillTreeBgWave => GetSpriteFromAsset("s_skill_tree_bg_wave");
        public static Sprite SliderBall => GetSpriteFromAsset("s_slider_ball");
        public static Sprite SliderBgEdge => GetSpriteFromAsset("s_slider_bg_edge");
        public static Sprite SliderBgWhiteEdge => GetSpriteFromAsset("s_slider_bg_white_edge");
        public static Sprite SliderBgWhite => GetSpriteFromAsset("s_slider_bg_white");
        public static Sprite SliderBg => GetSpriteFromAsset("s_slider_bg");
        public static Sprite Slope => GetSpriteFromAsset("s_slope");
        public static Sprite SmokeBiggerBkup => GetSpriteFromAsset("s_smoke_bigger_bkup");
        public static Sprite SmokeBigger => GetSpriteFromAsset("s_smoke_bigger");
        public static Sprite SmokeHit => GetSpriteFromAsset("s_smoke_hit");
        public static Sprite SmokeLonger => GetSpriteFromAsset("s_smoke_longer");
        public static Sprite SmokeSkillCanBuy => GetSpriteFromAsset("s_smoke_skill_can_buy");
        public static Sprite SmokeSmall => GetSpriteFromAsset("s_smoke_small");
        public static Sprite Smoke => GetSpriteFromAsset("s_smoke");
        public static Sprite Sparkle01 => GetSpriteFromAsset("s_sparkle_01");
        public static Sprite Sparkle02 => GetSpriteFromAsset("s_sparkle_02");
        public static Sprite Stair01 => GetSpriteFromAsset("s_stair_01");
        public static Sprite StarfishAttack => GetSpriteFromAsset("s_starfish_attack");
        public static Sprite StarfishIdle => GetSpriteFromAsset("s_starfish_idle");
        public static Sprite StarfishPosition => GetSpriteFromAsset("s_starfish_position");
        public static Sprite StoragePosition => GetSpriteFromAsset("s_storage_position");
        public static Sprite StoreChestClose => GetSpriteFromAsset("s_store_chest_close");
        public static Sprite StoreChestOpen => GetSpriteFromAsset("s_store_chest_open");
        public static Sprite StoreInventoryBg => GetSpriteFromAsset("s_store_inventory_bg");
        public static Sprite StoreInventorySlot => GetSpriteFromAsset("s_store_inventory_slot");
        public static Sprite StoreSafeClose => GetSpriteFromAsset("s_store_safe_close");
        public static Sprite StoreSafeOpen => GetSpriteFromAsset("s_store_safe_open");
        public static Sprite SubmarineBiomeBgIcon =>
            GetSpriteFromAsset("s_submarine_biome_bg_icon");
        public static Sprite SubmarineBubble => GetSpriteFromAsset("s_submarine_bubble");
        public static Sprite SubmarineDepthIcon01 =>
            GetSpriteFromAsset("s_submarine_depth_icon_01");
        public static Sprite SubmarineDepthIcon02 =>
            GetSpriteFromAsset("s_submarine_depth_icon_02");
        public static Sprite SubmarineDepthIcon03 =>
            GetSpriteFromAsset("s_submarine_depth_icon_03");
        public static Sprite SubmarineInfoBg => GetSpriteFromAsset("s_submarine_info_bg");
        public static Sprite SubmarineInventoryBg => GetSpriteFromAsset("s_submarine_inventory_bg");
        public static Sprite SubmarineInventorySlot =>
            GetSpriteFromAsset("s_submarine_inventory_slot");
        public static Sprite SubmarineLock => GetSpriteFromAsset("s_submarine_lock");
        public static Sprite SubmarineLockedDemoOverlay =>
            GetSpriteFromAsset("s_submarine_locked_demo_overlay");
        public static Sprite SubmarineSelector => GetSpriteFromAsset("s_submarine_selector");
        public static Sprite SubmarineStorageBroken =>
            GetSpriteFromAsset("s_submarine_storage_broken");
        public static Sprite SubmarineStorageFixed =>
            GetSpriteFromAsset("s_submarine_storage_fixed");
        public static Sprite Submarine => GetSpriteFromAsset("s_submarine");
        public static Sprite SwampRamp => GetSpriteFromAsset("s_swamp_ramp");
        public static Sprite TilesetMain => GetSpriteFromAsset("s_tileset_main");
        public static Sprite TilesetMidgroundProps =>
            GetSpriteFromAsset("s_tileset_midground_props");
        public static Sprite TilesetMidground => GetSpriteFromAsset("s_tileset_midground");
        public static Sprite TilesetProps => GetSpriteFromAsset("s_tileset_props");
        public static Sprite TransitionCircle => GetSpriteFromAsset("s_transition_circle");
        public static Sprite TransitionRamp => GetSpriteFromAsset("s_transition_ramp");
        public static Sprite TransitionSquare => GetSpriteFromAsset("s_transition_square");
        public static Sprite TransmutatorArrow => GetSpriteFromAsset("s_transmutator_arrow");
        public static Sprite TransmutatorInventoryBg =>
            GetSpriteFromAsset("s_transmutator_inventory_bg");
        public static Sprite TransmutatorInventorySlot =>
            GetSpriteFromAsset("s_transmutator_inventory_slot");
        public static Sprite TrashProp01 => GetSpriteFromAsset("s_trash_prop_01");
        public static Sprite TrashProp02 => GetSpriteFromAsset("s_trash_prop_02");
        public static Sprite TrashProp03 => GetSpriteFromAsset("s_trash_prop_03");
        public static Sprite TrashProp04 => GetSpriteFromAsset("s_trash_prop_04");
        public static Sprite TrashProp05 => GetSpriteFromAsset("s_trash_prop_05");
        public static Sprite TrashProp06 => GetSpriteFromAsset("s_trash_prop_06");
        public static Sprite TrashProp07 => GetSpriteFromAsset("s_trash_prop_07");
        public static Sprite TrashProp08 => GetSpriteFromAsset("s_trash_prop_08");
        public static Sprite TrashProp09 => GetSpriteFromAsset("s_trash_prop_09");
        public static Sprite UiCancelButton => GetSpriteFromAsset("s_ui_cancel_button");
        public static Sprite UiConfirmButton => GetSpriteFromAsset("s_ui_confirm_button");
        public static Sprite UiElementBg => GetSpriteFromAsset("s_ui_element_bg");
        public static Sprite UiElementBubblesIcon =>
            GetSpriteFromAsset("s_ui_element_bubbles_icon");
        public static Sprite UiElementPlasmaIcon => GetSpriteFromAsset("s_ui_element_plasma_icon");
        public static Sprite UiLeaveButton => GetSpriteFromAsset("s_ui_leave_button");
        public static Sprite UiOceanGlacialIcon => GetSpriteFromAsset("s_ui_ocean_glacial_icon");
        public static Sprite UiOceanMagmaIcon => GetSpriteFromAsset("s_ui_ocean_magma_icon");
        public static Sprite UiOceanShallowsIcon => GetSpriteFromAsset("s_ui_ocean_shallows_icon");
        public static Sprite UiOceanSwampIcon => GetSpriteFromAsset("s_ui_ocean_swamp_icon");
        public static Sprite UiRestartButton => GetSpriteFromAsset("s_ui_restart_button");
        public static Sprite UiSkillDescSelector => GetSpriteFromAsset("s_ui_skill_desc_selector");
        public static Sprite UiSkillGamepadDirection =>
            GetSpriteFromAsset("s_ui_skill_gamepad_direction");
        public static Sprite UiSkillSelector => GetSpriteFromAsset("s_ui_skill_selector");
        public static Sprite UiSubmarineBg => GetSpriteFromAsset("s_ui_submarine_bg");
        public static Sprite UiSubmarineBiomeSlot =>
            GetSpriteFromAsset("s_ui_submarine_biome_slot");
        public static Sprite UiToolAim => GetSpriteFromAsset("s_ui_tool_aim");
        public static Sprite UiToolBg => GetSpriteFromAsset("s_ui_tool_bg");
        public static Sprite UiToolSelector => GetSpriteFromAsset("s_ui_tool_selector");
        public static Sprite UiTurtleIconElement => GetSpriteFromAsset("s_ui_turtle_icon_element");
        public static Sprite UiVignette => GetSpriteFromAsset("s_ui_vignette");
        public static Sprite UpgradeAreaAntennaVfx =>
            GetSpriteFromAsset("s_upgrade_area_antenna_vfx");
        public static Sprite UpgradeAreaAntenna => GetSpriteFromAsset("s_upgrade_area_antenna");
        public static Sprite UpgradeArea => GetSpriteFromAsset("s_upgrade_area");
        public static Sprite WaterRamp => GetSpriteFromAsset("s_water_ramp");
        public static Sprite XpProgressBg => GetSpriteFromAsset("s_xp_progress_bg");
        public static Sprite XpProgressBk => GetSpriteFromAsset("s_xp_progress_bk");
        public static Sprite XpProgressShine => GetSpriteFromAsset("s_xp_progress_shine");
        public static Sprite XpProgressUiShine => GetSpriteFromAsset("s_xp_progress_ui_shine");
        public static Sprite XpProgressUi => GetSpriteFromAsset("s_xp_progress_ui");

        private readonly GameVariable index;
        private readonly int width = 0;
        private readonly int height = 0;
        private readonly int frames;
        private int currentFrame = -1;

        // TODO: Add support for sprite-offset

        public Sprite(string path, int frames = 1)
        {
            if (!path.StartsWith("mods/bubble/"))
            {
                path = "mods/bubble/" + path;
            }
            index = Game.Engine.CallFunction("sprite_add", path, 1, false, false, 0, 0);
            width = Game.Engine.CallFunction("sprite_get_width", index);
            height = Game.Engine.CallFunction("sprite_get_height", index);

            Game.Engine.CallFunction("sprite_set_offset", index, width / 2, height / 2);
            this.frames = frames;
        }

        public Sprite(GameVariable index)
        {
            this.index = index;
            width = Game.Engine.CallFunction("sprite_get_width", index);
            height = Game.Engine.CallFunction("sprite_get_height", index);

            this.frames = 1;
        }

        public static implicit operator GameVariable(Sprite sprite)
        {
            return sprite.index;
        }

        public static implicit operator Sprite(GameVariable index)
        {
            return new Sprite(index);
        }

        public int Width => width;

        public int Height => height;

        public int Frames => frames;

        //TODO: Provide animation functionality
        public int CurrentFrame
        {
            get => currentFrame;
            set => currentFrame = value;
        }

        /// <summary>
        /// <see href="https://manual.gamemaker.io/monthly/en/GameMaker_Language/GML_Reference/Drawing/Sprites_And_Tiles/draw_sprite_ext.htm"> GML doc</see>
        /// </summary>
        public void Draw(
            float x,
            float y,
            float scaleX = 1,
            float scaleY = 1,
            float angle = 0,
            int r = 255,
            int g = 255,
            int b = 255,
            int a = 255
        )
        {
            int colour = r + 256 * g + 256 * 256 * b;
            Game.Engine.CallFunction(
                "draw_sprite_ext",
                index,
                currentFrame,
                x,
                y,
                scaleX,
                scaleY,
                angle,
                colour,
                a / 255f
            );
        }

        /// <summary>
        /// <see href="https://manual.gamemaker.io/monthly/en/GameMaker_Language/GML_Reference/Drawing/Sprites_And_Tiles/draw_sprite_stretched.htm"> GML doc</see>
        /// </summary>
        public void DrawStretched(
            float x,
            float y,
            int width,
            int height,
            int r = 255,
            int g = 255,
            int b = 255,
            int a = 255
        )
        {
            int colour = r + 256 * g + 256 * 256 * b;
            Game.Engine.CallFunction(
                "draw_sprite_stretched",
                index,
                currentFrame,
                x,
                y,
                width,
                height,
                colour,
                a / 255f
            );
        }

        private static Sprite GetSpriteFromAsset(string assetName)
        {
            if (!loadedSprites.TryGetValue(assetName, out Sprite? value))
            {
                value = new Sprite(GML.GetAsset(assetName)!);
                loadedSprites.Add(assetName, value);
            }
            return value;
        }
    }
}
