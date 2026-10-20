Project Overview:
The Color Physics Counter is a real-time physics simulation built to demonstrate object interaction, event-driven UI updates, and web deployment.
In this project, a spawner continuously drops dynamically generated colored spheres into a translucent containment box.
As the objects fall into the collection zone, the game instantly detects their properties and tallies them on the screen by color.   

Technical Highlights:
Physics & Trigger Systems: Utilized Unity's physics engine by setting up a centralized trigger volume within 
a custom-built containment box (constructed from 3D cube primitives). The core logic relies on C# OnTriggerEnter events to register collisions
without impeding the physical momentum of the falling objects.   

Tag-Based Data Routing: Implemented a lightweight Counter.cs script that evaluates interacting objects using CompareTag("Red"),
CompareTag("Blue"), and CompareTag("Green"). This ensures only valid game objects are processed and counted.   

Dynamic UI Integration: Bridged the backend gameplay logic with Unity's UI Canvas. The script maintains separate integer variables
for each color and strictly updates the Text components only when a successful trigger event occurs, keeping the overhead low.   

WebGL & URP Optimization: Successfully configured and deployed the project to Unity Play via WebGL. This required specialized optimization
of the Universal Render Pipeline (URP) for web browser compatibility, including modifying global shader settings, managing WebGL graphics APIs,
and adjusting color space environments to ensure the 3D scene rendered accurately online.

Development Takeaways: This project served as an excellent practical application of Unity's event-driven architecture. 
By keeping the Counter script attached directly to the physical trigger zone rather than the individual spheres or the spawner, 
the architecture remains highly modular. The experience of debugging and publishing to Unity Play also provided valuable insight 
into the specific graphics and memory constraints of WebGL builds, ensuring future web-based projects will be structured for immediate browser compatibility.
