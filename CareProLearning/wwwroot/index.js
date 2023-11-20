function isElementPresent(id) {
    return !!document.getElementById(id);
}

function initializeVideoJS(videoId) {
    if (videojs.getPlayer(videoId)) {
        videojs(videoId).dispose();
    }
    console.log("Initializing Video.js for:", videoId);
    videojs(videoId, {
        playbackRates: [0.5, 1, 1.5, 2]
    });
}
