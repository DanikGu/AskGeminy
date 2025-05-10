# Gemini Integration Suite (Developer Tools)

A Chrome Extension and a PowerToys Run plugin designed for developers to streamline interaction with Gemini, enabling quicker querying and integration workflows.

## Table of Contents

1.  [Gemini Site Companion (Chrome Extension)](#gemini-site-companion-chrome-extension)
    * [Features](#features-chrome)
    * [Developer Installation (Chrome)](#developer-installation-chrome)
    * [Usage (Chrome)](#usage-chrome)
2.  [Gemini Quick Launcher (PowerToys Plugin)](#gemini-quick-launcher-powertoys-plugin)
    * [Features (PowerToys)](#features-powertoys)
    * [Prerequisites (PowerToys)](#prerequisites-powertoys)
    * [Developer Installation (PowerToys)](#developer-installation-powertoys)
    * [Usage (PowerToys)](#usage-powertoys)
3.  [License](#license)

---

## Gemini Site Companion (Chrome Extension)

This Chrome Extension enhances the Gemini website (`gemini.google.com`) for developers by allowing query prefill via URL and automatic microphone engagement.

<a name="features-chrome"></a>
### Features
* **URL Query Prefill:** Automatically populates the query input field on the Gemini website if a query is provided as a URL parameter (e.g., `gemini.google.com/app?q=your+query`).
* **Automatic Microphone Activation:** Optionally starts microphone input automatically upon navigation to the Gemini website. (Requires user permission for microphone access).

<a name="developer-installation-chrome"></a>
### Developer Installation (Chrome)
1.  Clone this repository or download the source code.
2.  To load the extension in Chrome in developer mode:
    * Follow the official guide for loading an unpacked extension: [Chrome Extension Development Basics - Loading an extension](https://developer.chrome.com/docs/extensions/mv3/getstarted/development-basics/#load-unpacked)

<a name="usage-chrome"></a>
### Usage (Chrome)

* **URL Query Prefill:**
    * Navigate to a URL like `https://gemini.google.com/app?q=Explain+CORS+policy`.
    * The extension will use the `q` parameter to prefill the Gemini query box.
* **Automatic Microphone Activation:**
    * Ensure microphone permission is granted to `gemini.google.com`.
    * The microphone will be ready for input when the Gemini page loads if the feature is enabled.

---

## Gemini Quick Launcher (PowerToys Plugin)

A plugin for PowerToys Run enabling developers to quickly launch the Gemini website with a query directly from the PowerToys Run interface.

<a name="features-powertoys"></a>
### Features (PowerToys)
* **Rapid Querying:** Use a keyword in PowerToys Run to send queries to Gemini.
* **Browser Integration:** Opens your default web browser to the Gemini site with your query.

<a name="prerequisites-powertoys"></a>
### Prerequisites (PowerToys)
* [PowerToys](https://aka.ms/PowerToys) installed.
* PowerToys Run enabled.

<a name="developer-installation-powertoys"></a>
### Developer Installation (PowerToys)
1.  Clone this repository or download the plugin source/build.
2.  To add the plugin to PowerToys Run:
    * Refer to the official PowerToys documentation on third-party plugin installation for PowerToys Run: [PowerToys Run plugin overview - Installing third party plugins](https://learn.microsoft.com/en-us/windows/powertoys/run#installing-third-party-plugins) (Note: You'll typically place the plugin in a specific folder like `%LOCALAPPDATA%\Microsoft\PowerToys\PowerToys Run\Plugins`).

<a name="usage-powertoys"></a>
### Usage (PowerToys)

1.  Open PowerToys Run (default: `Alt + Space`).
2.  Type the activation keyword (e.g., `gem`), followed by your query.
    * Example: `gem generate python code for a flask api`
3.  Press Enter.
4.  Your browser will open `https://gemini.google.com/app?q=generate+python+code+for+a+flask+api`.

*(The activation keyword might be configurable within the plugin's source or settings.)*

---

## License

This project is licensed under the MIT License - see the `LICENSE.md` file for details.
