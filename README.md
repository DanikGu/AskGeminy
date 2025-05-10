# Gemini Integration Suite

Enhance your interaction with Gemini through a dedicated Chrome Extension and a PowerToys Run plugin. This suite is designed to streamline your workflow and make accessing Gemini's capabilities quicker and more intuitive.

## Table of Contents

1.  [Gemini Site Companion (Chrome Extension)](#gemini-site-companion-chrome-extension)
    * [Features](#features-chrome)
    * [Installation (Chrome)](#installation-chrome)
    * [Usage (Chrome)](#usage-chrome)
2.  [Gemini Quick Launcher (PowerToys Plugin)](#gemini-quick-launcher-powertoys-plugin)
    * [Features (PowerToys)](#features-powertoys)
    * [Prerequisites (PowerToys)](#prerequisites-powertoys)
    * [Installation (PowerToys)](#installation-powertoys)
    * [Usage (PowerToys)](#usage-powertoys)
3.  [Contributing](#contributing)
4.  [License](#license)

---

## Gemini Site Companion (Chrome Extension)

This Chrome Extension enhances your experience on the Gemini website (`gemini.google.com`) by providing convenient ways to initiate queries and interact via voice.

<a name="features-chrome"></a>
### Features
* **URL Query Prefill:** Automatically populates the query input field on the Gemini website if a query is provided as a URL parameter (e.g., `gemini.google.com/app?customquery=your+query`).
* **Automatic Microphone Activation:** Optionally starts microphone input automatically when you navigate to the Gemini website, allowing for immediate voice commands. (Requires user permission for microphone access).

<a name="installation-chrome"></a>
### Installation (Chrome)

**Method 1: From the Chrome Web Store (Recommended)**
* (Link to be added once the extension is published)

**Method 2: Manual Installation (For Developers)**
1.  Download the latest release `.zip` file from the [Releases](../../releases) page or clone this repository.
2.  If downloaded, unzip the file to a dedicated folder on your computer.
3.  Open Google Chrome and navigate to `chrome://extensions`.
4.  Enable "Developer mode" using the toggle switch in the top-right corner.
5.  Click on the "Load unpacked" button.
6.  Select the directory where you unzipped/cloned the extension files.

<a name="usage-chrome"></a>
### Usage (Chrome)

* **URL Query Prefill:**
    * Simply navigate to a URL like `https://gemini.google.com/app?q=What+is+the+capital+of+France%3F`.
    * The extension will detect the `q` parameter and prefill "What is the capital of France?" into the Gemini query box.
* **Automatic Microphone Activation:**
    * The first time you visit `gemini.google.com` after installing the extension, you might be prompted to grant microphone access.
    * Once permission is granted (if the feature is enabled in extension settings), the microphone will be ready for input as soon as the Gemini page loads.
    * Check the extension's options page (if available) for any configuration related to this feature.

---

## Gemini Quick Launcher (PowerToys Plugin)

This plugin for PowerToys Run allows you to quickly open the Gemini website in your browser with a specific query, directly from the PowerToys Run launcher.

<a name="features-powertoys"></a>
### Features (PowerToys)
* **Rapid Querying:** Use a simple keyword in PowerToys Run to send queries to Gemini.
* **Seamless Browser Integration:** Opens your default web browser directly to the Gemini site with your query pre-filled.

<a name="prerequisites-powertoys"></a>
### Prerequisites (PowerToys)
* [PowerToys](https://aka.ms/PowerToys) must be installed and running on your Windows machine.
* PowerToys Run must be enabled in the PowerToys settings.

<a name="installation-powertoys"></a>
### Installation (PowerToys)
1.  Download the latest plugin release from the [Releases](../../releases) page.
2.  Ensure PowerToys is not running (Exit from the system tray).
3.  Locate your PowerToys Run plugins directory. This is typically found at:
    * `%LOCALAPPDATA%\Microsoft\PowerToys\PowerToys Run\Plugins`
    * Or, if installed for all users: `C:\Program Files\PowerToys\RunPlugins`
4.  Extract the plugin folder from the downloaded archive into this directory.
5.  Start PowerToys. The plugin should be automatically loaded. You can verify this in the PowerToys Settings > PowerToys Run > Plugins list.

<a name="usage-powertoys"></a>
### Usage (PowerToys)

1.  Open PowerToys Run (default shortcut: `Alt + Space`).
2.  Type the activation keyword for the Gemini plugin (e.g., `gem`), followed by your query.
    * Example: `gem What are the latest AI advancements?`
3.  Press Enter.
4.  Your default web browser will open `https://gemini.google.com/app?customquery=What+are+the+latest+AI+advancements%3F` (or the equivalent URL-encoded query).

*(The activation keyword might be configurable. Please check the plugin's settings or documentation if available.)*

---

## License

This project is licensed under the MIT License - see the `LICENSE.md` file for details.
