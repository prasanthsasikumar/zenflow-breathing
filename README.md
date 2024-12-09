# **Breath Detection in Unity (Inhale/Exhale Tracker)**  

This Unity project implements a basic system to detect inhale and exhale breathing patterns using a microphone. It uses audio input to analyze volume changes and classify breathing states (inhale/exhale) in real time.  

---

## **Features**  
- Captures real-time audio input via a microphone.  
- Processes audio data to detect breathing patterns based on volume thresholds.  
- Outputs detected states (`Inhaling` or `Exhaling`) in the Unity console.  
- Lightweight and easy to integrate into VR applications.  

---

## **Getting Started**  

### **Prerequisites**  
- Unity 2021.3 or later.  
- A computer with a microphone (built-in or external).  
- Optional: VR headset (e.g., Meta Quest) for testing in VR.  

### **Setup**  
1. Clone or download this repository.  
   ```bash
   git clone https://github.com/prasanthsasikumar/zenflow-breathing.git
   ```
2. Open the project in Unity.  

3. Attach the `BreathDetection` script to an empty GameObject in your scene.  

4. Play the scene to begin testing the feature.  

---

## **Usage**  

1. **Start Breathing Detection**:  
   - Upon running the scene, the microphone will begin capturing audio.  
   - Check the Unity Console for real-time logs:  
     - `Inhaling...`  
     - `Exhaling...`  

2. **Adjust Detection Thresholds**:  
   Modify the following constants in the script to fine-tune detection for different users:
   ```csharp
   private const float inhaleThreshold = 0.05f;
   private const float exhaleThreshold = 0.1f;
   ```

---

## **Code Overview**  

### **BreathDetection Script**  
The `BreathDetection` script performs the following steps:  
1. **Start Microphone**:  
   Captures audio using Unity's `Microphone` API.  

2. **Analyze Audio Data**:  
   - Computes the **Root Mean Square (RMS)** of audio samples to measure volume.  
   - Compares the volume to predefined thresholds to classify as inhale or exhale.  

3. **Output Breathing State**:  
   Logs the current state (`Inhaling` or `Exhaling`) to the Unity console.  


## **Testing**  

### **Steps to Test**  
1. Open the Unity project.  
2. Run the scene.  
3. Observe the console logs as you breathe near the microphone:  
   - Quiet inhale should log `Inhaling`.  
   - Louder exhale should log `Exhaling`.  

### **Test Environments**  
- Quiet room (recommended for better detection).  
- VR setup for integration with immersive applications.  

---

## **Future Improvements**  
- Add **visual feedback** (e.g., a bar or circle expanding/contracting with breath).  
- Integrate **noise reduction** to enhance accuracy in noisy environments.  
- Explore **machine learning models** for advanced breath classification.  

---

## **Contributing**  
Contributions are welcome! Please follow these steps:  
1. Fork this repository.  
2. Create a feature branch: `git checkout -b feature-name`.  
3. Commit your changes: `git commit -m 'Add feature'`.  
4. Push to the branch: `git push origin feature-name`.  
5. Submit a pull request.  

---

## **Contact**  
For questions or feedback, reach out to:  
- **Your Name**: [prasanth@ahlab.org](mailto:prasanth@ahlab.org)  
- GitHub: [@prasanthsasikumar](https://github.com/prasanthsasikumar)  

