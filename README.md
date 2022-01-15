## gankplank-demo
Created together with Taehoon Kim, Adeeb Mahmud, and Atif Mahmud for the GI Jams 2020 summer jam.

Tech demo for a graphical rendering and asset production pipeline created in 42 hours for the 
UW Games Institute summer jam of 2020. Graphical rendering pipeline that enables game developers to turn animated 3D models into detailed 2D sprite sheets that include beautiful, dynamic 2D normal maps. Created a visually striking "ToonLit" shader in HLSL for the Unity3D engine that converts smooth, 
3D shadows into 2D pixel-art style shading.

Traditionally, adding realistic lighting and shadow effects to 2D sprites is very difficult since the sprites have no actual 3D characteristics and it requires the sprite artist to have a lot of talent to accurately add shadows. Instead, we take advantage of the geometry of 3D models to compute the reflections of lightrays by casting rays onto the 3D models and then using math (mostly linear algebra) to transform these computer calculating lighting features onto a 2D normalmap for a sprite generated from taking a sideprofile of the 3D model.

Currently the project is a tech demo and is not a representation of a fully implemented product. Please read the documents inside the PRESSKIT folder for more information.
