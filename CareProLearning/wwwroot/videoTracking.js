window.initializeVideoPlayer = function (videoId, dotNetReference) {
    if (videojs.getPlayers()[videoId]) {
        videojs.getPlayers()[videoId].dispose();
    }

    var videoElement = document.getElementById(videoId);
    if (videoElement) {
        var player = videojs(videoId, {
            playbackRates: [0.5, 1, 1.5, 2]
        }, function onPlayerReady() {
            this.on('timeupdate', function () {
                var progress = this.currentTime();
                var isCompleted = this.ended();
                dotNetReference.invokeMethodAsync('UpdateVideoProgress', videoId, progress, isCompleted);
            });

            window.addEventListener('beforeunload', function () {
                var progress = player.currentTime();
                dotNetReference.invokeMethodAsync('SaveProgressOnUnload', videoId, progress);
            });

            this.on('loadedmetadata', function () {
                var duration = this.duration();
                dotNetReference.invokeMethodAsync('SetVideoLength', parseInt(videoId), duration);
            });
        });
    } else {
        console.error("Video element with ID '" + videoId + "' was not found.");
    }
};

window.disposeVideoPlayer = function (videoId) {
    var player = videojs.getPlayers()[videoId];
    if (player) {
        player.dispose();
    }
};
