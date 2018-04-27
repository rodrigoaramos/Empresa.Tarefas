/// <reference path="../Scripts/typings/jquery/jquery.d.ts" />
function Welcome(person) {
    return "<h2>Hello " + person + ", Lets learn TypeScript</h2>";
}
function ClickMeButton() {
    var user = "MithunVP";
    document.getElementById("divMsg").innerHTML = Welcome(user);
}
//# sourceMappingURL=main.js.map