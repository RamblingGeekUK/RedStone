using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStone.Models
{
    public class ServerProperties
    {
        public string servername { get; set; } = "Dedicated Server";
        public string gamemode { get; set; } = "survial";
        public string force_gamemode { get; set; } = "false";
        public string difficulty { get; set; } = "easy";
        public string allow_cheats { get; set; } = "false";
        public string max_players { get; set; } = "10";
        public string online_mode { get; set; } = "true";
        public string white_list { get; set; } = "false";
        public string server_port { get; set; } = "19132";
        public string server_portv6 { get; set; } = "19133";
        public string view_distance { get; set; } = "32";
        public string tick_distance { get; set; } = "4";
        public string player_idle_timeout { get; set; } = "30";
        public string max_threads { get; set; } = "8";
        public string level_name { get; set; } = "Bedrock Level";
        public string level_seed { get; set; }
        public string default_layer_permission_level { get; set; } = "member";
        public string texturepack_required { get; set; } = "false";
        public string content_log_file_enabled { get; set; } = "false";
        public string compression_threshold { get; set; } = "1";
        public string server_authoritative_movement { get; set; } = "server-auth";
        public string player_movement_score_threshold { get; set; } = "1";
        public string player_movement_distance_threshold { get; set; } = "0.3";
        public string player_movement_duration_threshold_in_ms { get; set; } = "500";
        public string correct_player_movement { get; set; } = "false";
        public string server_authoritative_block_breaking { get; set; } = "false";

        public string value { get; set; }
    }
}
