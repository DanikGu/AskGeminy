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
1.  Build Powertoys plugin, publish.
2.  Ensure PowerToys is not running (Exit from the system tray).
3.  Locate your PowerToys Run plugins directory. This is typically found at:
    * `%LOCALAPPDATA%\Microsoft\PowerToys\PowerToys Run\Plugins`
    * Or, if installed for all users: `C:\Program Files\PowerToys\RunPlugins`
4.  Put builded plugin to plugtins directory.
5.  Start PowerToys. The plugin should be automatically loaded. You can verify this in the PowerToys Settings > PowerToys Run > Plugins list.
---

## License

This project is licensed under the MIT License - see the `LICENSE.md` file for details.
