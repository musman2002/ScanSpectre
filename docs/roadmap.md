# 📘 Documentation

This section auto-generates structure and descriptions to help developers.

## 🔧 Core Classes

### **AddressScanner.cs**

Handles:

* TCP connect attempts
* Timeout logic
* Multi-threaded scanning
* Reporting results back to the UI

### **AddressList.cs**

Models port ranges and

* Generates port sequences
* Validates ranges
* Prepares values for scanning

### **ScanSpectre.cs**

* UI event handlers
* Updates DataGridView
* Controls thread management
* Coordinates scanner operations

---


# ## 🧩 Features Checklist

Below is a complete overview of features already included in **ScanSpectre**, along with potential enhancements planned for future updates.

---

## ✔️ **Implemented Features**

### **🔍 Core Scanning**

* [x] TCP port scanning (IP / Domain)
* [x] Customizable port range (Start → End)
* [x] Adjustable timeout for connections
* [x] Multi-threaded scanning using `SemaphoreSlim`
* [x] Fully async scanning engine
* [x] Real-time result updates in DataGridView
* [x] Clean architecture (`AddressScanner`, `AddressList`, `ScanResult`)

### **🎨 UI / UX**

* [x] Modern Guna UI2 interface
* [x] Borderless window with rounded corners
* [x] Built-in window shadow
* [x] Slide-out settings panel
* [x] Light/Dark theme switching (`ThemeManager`)
* [x] Automatic theming for:

  * [x] Buttons
  * [x] TextBoxes
  * [x] Labels
  * [x] Panels
  * [x] DataGridView

### **🚀 Enhanced Startup Experience**

* [x] Splash screen with:

  * [x] Fade-in / fade-out transition
  * [x] Pulse/scale animated app logo
  * [x] Animated "Loading…" text with blinking dots
  * [x] Simulated loading progress bar
  * [x] Startup audio cue (optional)
  * [x] Borderless rounded UI
  * [x] Drop shadow + Double Buffering

---

## ➕ **Planned / Optional Future Enhancements**

### **🔍 Advanced Scanning Features**

* [ ] UDP scanning
* [ ] SYN/Stealth scanning (SharpPcap)
* [ ] Banner grabbing / service fingerprinting
* [ ] OS detection heuristics
* [ ] Multi-host batch scanning
* [ ] IPv6 support
* [ ] Proxy (SOCKS5 / HTTP) scanning
* [ ] Scan presets (Quick / Full / Custom)
* [ ] Scan speed modes (slow accurate / high-speed)

### **📊 UI & Visualization**

* [ ] Scan progress graphs
* [ ] Chart for open/closed port distribution
* [ ] Real-time logging panel
* [ ] Results export:

  * [ ] JSON
  * [ ] CSV
  * [ ] TXT
* [ ] Import target lists
* [ ] Customizable color themes
* [ ] Animated scanning visualization

### **🪟 Window & Startup Upgrades**

* [ ] Exit animation
* [ ] Window materialization animation
* [ ] Acrylic/Mica blur (Windows 11/12)
* [ ] Particle effects on splash screen
* [ ] Lottie JSON animated logo

### **🔐 Security Utilities**

* [ ] Vulnerability detection rules
* [ ] Risk scoring for common ports
* [ ] Exposed service warnings
* [ ] Auto-recommendation system

### **🧑‍💻 Developer Features**

* [ ] Plugin system
* [ ] Unit tests for scanner logic
* [ ] Localization / multilingual support
* [ ] GitHub Pages documentation site
* [ ] MSIX installer packaging
* [ ] Modular engine improvements

---

