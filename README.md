# VoiceInput

## Description
**VoiceInput** is a Unity project that demonstrates how to use a microphone as an input device to detect audio loudness and trigger in-game actions based on voice input. This project was inspired by the video tutorial "How to Use Your Voice as Input in Unity - Microphone and Audio Loudness Detection." The project showcases two primary use cases: making a character's mouth move when speaking and detecting when the player blows into the microphone.

## Features
- **Audio Loudness Detection**: Detects the loudness of audio clips or live microphone input.
- **Character Animation**: Adjusts the scale of an object (e.g., a character's mouth) based on the loudness of the audio, simulating speech.
- **Microphone Input Handling**: Uses the microphone to detect voice input and trigger actions in the game.
- **Practical Use Cases**: Includes examples such as making a character talk or detecting when a player blows into a microphone to interact with in-game objects.

## Installation
To set up this project locally, follow these steps:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/VoiceInput.git
   cd VoiceInput

1. **Open in Unity:**

    - Open the project folder in Unity.
    - Ensure that you have the required Unity version installed that supports the scripts and features used in this project.

1. **Set Up the Scene:**

    - Follow the steps provided in the video tutorial to set up the necessary GameObjects, such as an audio source and the objects that will respond to the audio input.

1. **Run the Project:**

    - Once the setup is complete, you can run the project in Unity to see how the microphone input affects the in-game objects.

## Example Code

Here is a code snippet that shows how the project handles audio loudness detection from a microphone:

    private void GetLoudnessFromMicrophone() {
        // Create a microphone audio clip
        string microphoneName = Microphone.devices[0];
        microphoneClip = Microphone.Start(microphoneName, true, 20, AudioSettings.outputSampleRate);

        // Get the loudness from the microphone
        float loudness = GetLoudnessFromAudioClip(Microphone.GetPosition(microphoneName), microphoneClip);

        // Use the loudness to affect in-game objects
        if (loudness > threshold) {
            // Trigger an in-game action, such as scaling an object or playing a particle system
        }
    }

This function detects the loudness from the microphone and triggers an in-game action if the loudness exceeds a certain threshold.

## Video Tutorial

This project is based on the video tutorial by Valem Tutorials, which can be found here:

[How to Use Your Voice as Input in Unity - Microphone and Audio Loudness Detection](https://www.youtube.com/watch?v=dzD0qP8viLw).


License
This project is licensed under the MIT License. See the LICENSE file for more information.
