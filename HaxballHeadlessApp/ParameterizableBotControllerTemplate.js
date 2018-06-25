
var room = HBInit(
    {
        roomName: "{{RoomName}}",
        playerName: "{{PlayerName}}",
        maxPlayers: {{ MaxPlayers }},{{#Password}}
        password: "{{Password}}", {{/Password}}
        public: {{BoolToString Public}} {{#OverrideGeoLoc}},
        geo: {
            "code": "{{GeoCode}}",
            "lat": {{GeoLat}},
            "long": {{GeoLong}}
        } {{/OverrideGeoLoc}}
    }
);
room.setDefaultStadium("Big");
room.setScoreLimit(5);
room.setTimeLimit(0);

// If there are no admins left in the room give admin to one of the remaining players.
function updateAdmins() {
    // Get all players except the host (id = 0 is always the host)
    var players = room.getPlayerList().filter((player) => player.id != 0);
    if (players.length == 0) return; // No players left, do nothing.
    if (players.find((player) => player.admin) != null) return; // There's an admin left so do nothing.
    room.setPlayerAdmin(players[0].id, true); // Give admin to the first non admin player in the list
}

room.onPlayerJoin = function (player) {
    room.sendChat("Welcome " + player.name + " to our room");
    updateAdmins();
}

room.onGameStart = function(byPlayer) {
    room.sendChat("Game started! Good luck!");
}

room.onGameStop = function (byPlayer) {
    room.sendChat("Ups, game stopped!");
}

room.onPlayerLeave = function (player) {
    updateAdmins();
}
