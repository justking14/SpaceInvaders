

    * Audio Source (multiple): player serves as audio source for firing sound. enemies are the source for steps and death sounds.  Floor is source for background audio.

    * Basic C# scripting of audio playback events: move2 plays the firing sound, while move plays the death and step sound

    * Varying pitch, amplitude, etc.  move2 plays the firing sound with it's pitch randomly altered

    * Sounds triggered through collision: move triggers the death sound when it collides with something

    * A looping background "musical" track: background is played on loop from the floor


Original Sound: birds chirping (included in Assets/Audio/hwk1/hwk1/original.wav)
Background: Fade out, Inverted, reversed, sped up
Shoot: Boosted Bass, lowered Treble, applied leveler, added reverb, fade in, fade out, speed up, fade out
Death: Boosted Bass, lowered Treble, applied leveler, added reverb, fade in, fade out, speed up 200%
Step: speed up, leveler, wah, wah