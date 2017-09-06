var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('PhotoShare');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);