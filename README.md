# GIF Roulette
The C# code block for a Twitch channel point reward that takes a search word/phrase and returns a GIF to set as an OBS browser source URL.

## Installation

The code is designed to be used in the (Streamer.bot app([https://streamer.bot/], it will not work on its own. Create an action and an an "Execute C# Code" sub-action. Replace the default contents with the code in the file. You'll need to capture an input, such as from a chat command, channel point reward, etc. that you can feed to the code to use as the search term on GIPHY.

The code will then take the result, strip out the URL of the GIF, and pass it back to your action as a variable that you can use for other things. For example, I use it to change the URL of a browser source in OBS.
