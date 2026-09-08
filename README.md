<details>
<summary>Disclaimer</summary>
This repo primarily exists for personal use, and so projects I'm working on that have multiple programmers can share these utility/helper classes. Again, please note that these tools are built for my own projects; <b><ins>this means that they could change in functionality at any time</ins></b>. If you plan on using them long term, I strongly suggest sticking to one version/installing a packing and sticking to it, or paying very close attention to each update/commit. Feel free to use these in your own projects or base your own code off of mine, no credit needed; just don't claim it as your own.
</details>

# UtilityScripts
Lots of miscellaneous components and extension scripts for various classes/types. Here are some of the main features:

## Editor
- Albedo View Toggle
- Orient to Surface Component

## Components
- Raycaster
- TransformSpring (very buggy - breaks at low framerates in regular Update(), stutters at high framerates in FixedUpdate)

## Data Classes
- EAxis - Simple flags enum with [X, Y, Z] values
- ListWrapper - Literally just a List. I made this to be able to store Lists within Lists.

## Extensions
- AudioSourceExtensions
- CanvasGroupExtensions
- ComponentExtensions
- EnumerableExtensions
- GameObjectExtensions
- MeshRendererExtensions
- NavMeshExtensions
- RigidbodyExtensions
- SceneExtensions
- VectorExtensions

## Helper Classes
- WaitFunctions
- Timer
- ObjecWithProbability
- RandomFunctions
- RandomObjectContainer

## Physics
- Spring

Some of these utility scripts are based off of [git-ammend's Unity Utils](https://github.com/adammyhre/Unity-Utils)
