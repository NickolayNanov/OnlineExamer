var wasmHelper = {};

wasmHelper.ACCESS_TOKEN_KEY = "__access_token__";
wasmHelper.saveAccessToken = function (token) {
    localStorage.setItem(wasmHelper.ACCESS_TOKEN_KEY, token)
    console.log("Token Set Successfully")
};

wasmHelper.getAccessToken = function (item) {
    let token = localStorage.getItem(item);
    return token;
}