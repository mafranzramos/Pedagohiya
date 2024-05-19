using NAudio.Wave;

public static class SoundManager
{
    private static WaveOutEvent waveOut = new WaveOutEvent();

    public static bool IsMuted { get; private set; } = false;

    public static void ToggleMute()
    {
        IsMuted = !IsMuted;
        waveOut.Volume = IsMuted ? 0.0f : volumeLevel;
    }

    private static float volumeLevel = 1.0f * 0.7f;

    public static float VolumeLevel
    {
        get { return volumeLevel; }
        set
        {
            volumeLevel = value;
            if (waveOut != null)
            {
                waveOut.Volume = Math.Min(1.0f, Math.Max(0.0f, volumeLevel)); 
            }
        }
    }

}
