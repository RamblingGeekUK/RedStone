using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStone.Models
{
    public class ServerProperties
    {

        public string gamemode { get; set; }
        public string force_gamemode { get; set; }
        public string difficulty { get; set; }
        public string allow_cheats { get; set; }
        public string max_players { get; set; }
        public string online_mode { get; set; }
        public string white_list { get; set; }
        public string server_port { get; set; }
        public string server_portv6 { get; set; }
        public string view_distance { get; set; }
        public string tick_distance { get; set; }
        public string player_idle_timeout { get; set; }
        public string max_threads { get; set; }
        public string level_name { get; set; }
        public string level_seed { get; set; }
        public string default_layer_permission_level { get; set; }
        public string texturepack_required { get; set; }
        public string content_log_file_enabled { get; set; }
        public string compression_threshold { get; set; }
        public string server_authoritative_movement { get; set; }
        public string player_movement_score_threshold { get; set; }
        public string player_movement_distance_threshold { get; set; }
        public string player_movement_duration_threshold_in_ms { get; set; }
        public string correct_player_movement {get;set;}
        public string server_authoritative_block_breaking { get; set; }

        public string value { get; set; }
    }
}
