
<h1>Windows AI Assistant</h1><br>
<br>
<b>A voice-controlled AI Assistant for Microsoft Windows</b><br><br>
<h2>Features:</h2><br>
-Seamlessly integrates with Ollama or ChatGPT<br>
-Advanced voice recognition powered by Azure speech services<br>
-Hands-free interaction with your Windows system:<br>
--Program starter using key sentences<br>
--Webhooks using key sentences for integration with IFTTT (home automation etc.) - https://ifttt.com/ <br>
  (untested)
<br><br>

<h2>Download:</h2><br>
https://github.com/decipher2k/Windows-AI-Assistant/releases/download/v0.3/Windows.AI.Assistant.zip<br><br>
<h2>Usage:</h2><br>
<br>
After starting the application, a tray icon is being added. Doubleclick on it to configure the settings.<br>
Setup the API keys and other information using the "Settings" buttons.<br>
<br>
<h3>Microsoft Azure speech recognition:</h3><br>
https://github.com/dessant/buster/wiki/Configuring-Microsoft-Azure-Speech-to-Text <br>
<br>
<h3>ChatGPT:</h3><br>
https://medium.com/latinxinai/how-to-get-api-key-for-chat-gpt-3-5-or-4-0-fce40b35aa00 <br>
<br>
<h3>Ollama:</h3><br>
(https://ollama.com/)<br>
Ollama is a locally hosted Chat AI. Good hardware (Geforce RTX) with at least 8GB VRAM is suggested for running 7B models, but 12GB-16GB VRAM are better for running basic models.<br>
Some models (3B etc.) will work with less VRAM at the cost of quality.<br>
Good models (70B) will require 24GB VRAM and more.<br>
Set the model name and a system prompt in the settings window.<br>
You can find models at https://ollama.com/search <br>
<br>
<h3>Elevenlabs:</h3><br>
Log in to your ElevenLabs account.<br>
In the top-right corner, click on your profile icon > Profile.<br>
Next to the API Key field, click the eye icon to view and copy your API key and store it in a safe place.<br>
Please note: The "voice" field referes to the name of the voice, not to its ID.<br>
<br>
<h3>Keyword:</h3><br>
You can set a custom keyword for starting speech recognition. Default is "Computer".<br>
Thus you can say "Computer, who was John F. Kennedy" to get informations about John F. Kennedy.<br>
<br>
<h2>Costs:</h2><br>
<br>
<h3>Speech Recognition:</h3><br>
-Microsoft Azure (5h/month are free)<br>
<br>
<h3>AI Chat - one of the following:</h3><br>
-Ollama (free, requires good hardware)<br>
-ChatGPT API (about 10$/month)<br>
<br>
<h3>Speech output - one of the following:</h3><br>
-Microsoft Windows Speech (free, average quality)<br>
-Elevenlabs (about 10$/month, good quality)<br>
<br>
Please note that prices are dependent on real usage and may vary.


