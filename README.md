<div align="center">

<img src="https://placehold.co/120x120/1a1a2e/00d4ff?text=ASH&font=montserrat" alt="ASHPRO Logo" width="120" height="120" style="border-radius: 20px;" />

# ⚡ ASHPRO Desktop Suite

### *One Application. Three Powerhouses.*

A modern, feature-rich Windows Desktop Suite built with **C# & Windows Forms (.NET)** — combining a full-featured Media Player, a Rich Text Editor, and a complete Time Management toolkit into one cohesive, elegant application.

---

[![.NET](https://img.shields.io/badge/.NET-Windows%20Forms-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-Language-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![LibVLCSharp](https://img.shields.io/badge/LibVLCSharp-Media%20Engine-FF8800?style=for-the-badge&logo=vlcmediaplayer&logoColor=white)](https://github.com/videolan/libvlcsharp)
[![Guna UI2](https://img.shields.io/badge/Guna.UI2-Modern%20UI-00C4CC?style=for-the-badge&logo=nuget&logoColor=white)](https://gunaui.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)
[![PRs Welcome](https://img.shields.io/badge/PRs-Welcome-brightgreen.svg?style=for-the-badge)](http://makeapullrequest.com)
[![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)](https://www.microsoft.com/windows)

</div>

---

## 📋 Table of Contents

- [✨ Overview](#-overview)
- [🎯 Features](#-features)
  - [🎬 Advanced Media Player](#-advanced-media-player)
  - [📝 Rich Text Editor](#-rich-text-editor)
  - [⏱️ Time Management Tools](#️-time-management-tools)
- [⌨️ Keyboard Shortcuts](#️-keyboard-shortcuts)
- [📸 Screenshots](#-screenshots)
- [🚀 Installation & Setup](#-installation--setup)
- [🛠️ Tech Stack](#️-tech-stack)
- [📁 Project Structure](#-project-structure)
- [🤝 Contributing](#-contributing)
- [📄 License](#-license)
- [👤 Author](#-author)

---

## ✨ Overview

**ASHPRO Desktop Suite** is a unified productivity and entertainment application for Windows that eliminates the need for multiple standalone tools. Whether you're watching a video, drafting a document, or tracking your time — ASHPRO has you covered in a single, polished interface.

> 💡 **Built with a focus on:** Modern UI design, performance, keyboard-first workflows, and an intuitive user experience — all powered by a robust C# / .NET foundation.

---

## 🎯 Features

### 🎬 Advanced Media Player

Powered by **LibVLCSharp** — a battle-tested, codec-free media engine trusted by millions.

- 📂 **Open & Manage Media** — Load single files or entire playlists with ease
- ▶️ **Full Playback Controls** — Play, Pause, Stop, Next, Previous
- 🔁 **Flexible Repeat Modes** — Repeat All, Repeat One, or Repeat Off
- 🎚️ **Interactive Sliders** — Smooth video timeline scrubbing and volume control via custom `Guna.UI2` TrackBars
- 🖥️ **Full Screen Mode** — Immersive, distraction-free playback
- 🔇 **Mute/Unmute Toggle** — Instant audio control
- ⌨️ **Power-User Keyboard Shortcuts** — Navigate and control playback without touching the mouse *(see [Keyboard Shortcuts](#️-keyboard-shortcuts) below)*
- 🎨 **Modern Sleek UI** — Designed with `Guna.UI2` for custom buttons, controls, and an elegant dark/modern theme

---

### 📝 Rich Text Editor

A lightweight yet fully capable **WordPad-like** editor, right inside the suite.

- 📄 **File Management** — New, Open, Save, and Exit with unsaved-change detection
- 📋 **Complete Edit Operations** — Cut, Copy, Paste, Undo, Redo, Select All
- 🔤 **Rich Text Formatting:**
  - 🖋️ Change **Font Family** and **Font Size** via native `FontDialog`
  - 🎨 Apply custom **Text Color** using `ColorDialog`
  - **Bold**, *Italic*, Underline support
- 💾 **Format Support** — Works with `.txt`, `.rtf`, and other text-based formats
- ⌨️ **Standard Shortcuts** — All familiar `Ctrl+Z`, `Ctrl+C`, `Ctrl+V`, `Ctrl+S` shortcuts supported out-of-the-box

---

### ⏱️ Time Management Tools

Three essential time utilities in one unified panel.

#### 🕐 Digital Clock
- Real-time digital clock powered by a WinForms `Timer`
- Clean, always-accurate display — updates every second

#### ⏱ High-Precision Stopwatch
- Powered by the native C# `System.Diagnostics.Stopwatch` class
- Displays **hours, minutes, seconds, and milliseconds** with full precision
- **Start**, **Stop**, and **Reset** controls

#### ⏰ Alarm
- Set a target time using an intuitive **`DateTimePicker`** control
- When the alarm triggers:
  - 🔔 Plays a system alert sound via `SystemSounds.Exclamation`
  - 💬 Displays a prominent popup notification message
- Lightweight and reliable — no background services required

---

## ⌨️ Keyboard Shortcuts

All shortcuts are available globally within the Media Player window via `ProcessCmdKey`.

| Key Combination | Action |
|:---:|:---|
| `Space` | ▶️ Play / Pause toggle |
| `→` Right Arrow | ⏩ Seek Forward 5 seconds |
| `←` Left Arrow | ⏪ Seek Backward 5 seconds |
| `↑` Up Arrow | 🔊 Volume Up |
| `↓` Down Arrow | 🔉 Volume Down |
| `M` | 🔇 Mute / Unmute |
| `F` | 🖥️ Toggle Full Screen |
| `Esc` | ↩️ Exit Full Screen |
| `Shift + ?` | ℹ️ Show Keyboard Shortcuts Dialog |

---

## 📸 Screenshots

> 🖼️ *Replace the placeholder image URLs below with actual screenshots from your application.*

<div align="center">

### 🎬 Media Player Module
![Media Player Screenshot](https://placehold.co/800x500/1a1a2e/00d4ff?text=Media+Player+Screenshot&font=montserrat)

---

### 📝 Text Editor Module
![Text Editor Screenshot](https://placehold.co/800x500/1a1a2e/00d4ff?text=Text+Editor+Screenshot&font=montserrat)

---

### ⏱️ Time Management Module
![Time Tools Screenshot](https://placehold.co/800x500/1a1a2e/00d4ff?text=Time+Management+Screenshot&font=montserrat)

---

### 🏠 Main Dashboard / Home Screen
![Dashboard Screenshot](https://placehold.co/800x500/1a1a2e/00d4ff?text=Main+Dashboard+Screenshot&font=montserrat)

</div>

---

## 🚀 Installation & Setup

Follow these steps to get **ASHPRO Desktop Suite** running on your local machine.

### Prerequisites

Before you begin, make sure you have the following installed:

- ✅ [**Visual Studio 2022**](https://visualstudio.microsoft.com/) (or later) with the **.NET Desktop Development** workload
- ✅ [**.NET Framework / .NET 6+**](https://dotnet.microsoft.com/download) *(check the project's target framework in `.csproj`)*
- ✅ **NuGet Package Manager** *(included with Visual Studio)*
- ✅ **Windows OS** (Windows 10 or later recommended)

---

### Step 1 — Clone the Repository

```bash
git clone https://github.com/soghayarmahmoud/ashpro.git
cd ashpro-desktop-suite
```

> 🔁 Replace `soghayarmahmoud` with your actual GitHub username.

---

### Step 2 — Open the Solution

```
Open Visual Studio → File → Open → Project/Solution → select ASHPRO.sln
```

---

### Step 3 — Restore NuGet Packages

The project depends on two key NuGet packages. Visual Studio should restore them automatically on build, but you can also do it manually:

**Via Visual Studio:**
```
Right-click the Solution in Solution Explorer → Restore NuGet Packages
```

**Via .NET CLI:**
```bash
dotnet restore
```

#### Key Packages Being Restored:

| Package | Version | Purpose |
|---|---|---|
| `LibVLCSharp.WinForms` | Latest | Core media playback engine |
| `VideoLAN.LibVLC.Windows` | Latest | Native VLC binaries for Windows |
| `Guna.UI2.WinForms` | Latest | Modern UI controls & components |

> ⚠️ **Note on Guna.UI2:** This is a **commercial UI library**. You may need a valid license key or a trial version. Visit [gunaui.com](https://gunaui.com) for licensing details.

---

### Step 4 — Build & Run

1. Set the build configuration to **`Debug`** or **`Release`**
2. Press **`F5`** to build and run, or:

```bash
dotnet build
dotnet run
```

> 💡 If you encounter missing DLL errors related to `libvlc.dll`, ensure the `VideoLAN.LibVLC.Windows` NuGet package is correctly installed — it automatically copies the required native binaries to your output directory.

---

## 🛠️ Tech Stack

| Category | Technology / Library |
|---|---|
| **Language** | C# |
| **Framework** | .NET (Windows Forms) |
| **Media Engine** | [LibVLCSharp.WinForms](https://github.com/videolan/libvlcsharp) + VideoLAN.LibVLC.Windows |
| **UI Components** | [Guna.UI2.WinForms](https://gunaui.com/) |
| **Timing** | `System.Diagnostics.Stopwatch`, `System.Windows.Forms.Timer` |
| **Audio Alerts** | `System.Media.SystemSounds` |
| **Text Handling** | `System.Windows.Forms.RichTextBox` |
| **Dialogs** | `FontDialog`, `ColorDialog`, `OpenFileDialog`, `SaveFileDialog`, `DateTimePicker` |
| **IDE** | Visual Studio 2022 |
| **Package Manager** | NuGet |

---

## 📁 Project Structure

```
ashpro-desktop-suite/
│
├── 📁 ASHPRO/
│   ├── 📁 Forms/
│   │   ├── MainForm.cs           # Entry point / navigation hub
│   │   ├── MediaPlayerForm.cs    # Advanced Media Player module
│   │   ├── TextEditorForm.cs     # Rich Text Editor module
│   │   └── TimeToolsForm.cs      # Clock, Stopwatch & Alarm module
│   │
│   ├── 📁 Controls/              # Custom or reused UI controls
│   ├── 📁 Assets/                # Icons, images, and resources
│   ├── 📁 Properties/            # App settings & assembly info
│   │
│   ├── Program.cs                # Application entry point
│   └── ASHPRO.csproj             # Project file & NuGet references
│
├── 📄 ASHPRO.sln                 # Visual Studio Solution file
├── 📄 README.md                  # This file
└── 📄 LICENSE                    # MIT License
```

---

## 🤝 Contributing

Contributions, issues, and feature requests are warmly welcome!

1. **Fork** the repository
2. Create your feature branch: `git checkout -b feature/AmazingFeature`
3. Commit your changes: `git commit -m 'feat: Add some AmazingFeature'`
4. Push to the branch: `git push origin feature/AmazingFeature`
5. Open a **Pull Request**

Please make sure to update tests/documentation as appropriate and follow the existing code style.

[![PRs Welcome](https://img.shields.io/badge/PRs-Welcome-brightgreen.svg)](http://makeapullrequest.com)

---

## 📄 License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for full details.

```
MIT License — Free to use, modify, and distribute with attribution.
```

---

## 👤 Author

<div align="center">

### Mahmoud El-Soghayar


*Software Engineer & .NET Developer*

---

[![GitHub](https://img.shields.io/badge/GitHub-Follow-181717?style=for-the-badge&logo=github)](https://github.com/soghayarmahmoud)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Connect-0A66C2?style=for-the-badge&logo=linkedin)](https://linkedin.com/in/elsoghayar)
[![Email](https://img.shields.io/badge/Email-Contact-EA4335?style=for-the-badge&logo=gmail&logoColor=white)](mailto:mahmoudsruby@gmail.com)

</div>

---

<div align="center">

Built with ❤️ and C# by **Mahmoud El-Soghayar**

*If you found this project useful, please consider giving it a ⭐ — it means a lot!*

</div>
