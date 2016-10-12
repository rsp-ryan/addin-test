(function () {
    var customRenderingOverride = {};
    customRenderingOverride.Templates = {};
    customRenderingOverride.Templates.Header = "<h3><img src=\"../Images/RSP_logo.jpg\"><br /><br />タイムカード／日報</h3>"
    customRenderingOverride.Templates.Footer = "<h4><center>ライジングサン企画　エンタープライズスイート© 2016</center></h4>"
    customRenderingOverride.Templates.Fields = {
        "OrientationStage": { "View": renderOrientationStage }
    }
    SPClientTemplates.TemplateManager.RegisterTemplateOverrides(customRenderingOverride);

})();

function renderOrientationStage(ctx) {
    var orientationStageValue = ctx.CurrentItem[ctx.CurrentFieldSchema.Name];
    if (orientationStageValue == "最悪") {
        return "<span style='color:red'>" + orientationStageValue + "</span>"
    }
    else if (orientationStageValue == "絶好調") {
        return "<span style='color:green'>" + orientationStageValue + "</span>"
    }
    else if (orientationStageValue == "悪い") {
        return "<span style='color:orange'>" + orientationStageValue + "</span>"
    }
    else if (orientationStageValue == "良好") {
        return "<span style='color:blue'>" + orientationStageValue + "</span>"
    }
    
    else {
        return orientationStageValue;
    }
}