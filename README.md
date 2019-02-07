# Compiler Magic
Presentation originally for the OKC# user group.

[Slides](https://mronosa.github.io/techtalk-csharp-compiler-magic/reveal.js/index.html)

[Recording](https://www.twitch.tv/videos/179174859?t=26m25s) (Starts 26 minutes in)

Note: I answered a question incorrectly. You can set a dynamic variable to an anonymous value, then use it outside of your class. I updated `codeExamples.AnonymousTypes.AnonymousTypeExamples.Example2()` to reflect this.

## To the cloners

I recommend using Visual Studio Code to work with this presentation.  
To get `reveal.js` working:
 * Open the terminal
    - Press `ctrl`+`shift`+`p` and type `Terminal: Focus Terminal` (I'm expecting it to say "cmd.exe" in the drop-down on the top right, so I'll be listing Command Line commands)
* You will need NPM v4 or greater to serve `reveal.js`
    - (Tip) If you have [Node.js](https://nodejs.org/) installed, you could type `npm install -g npm` to install the latest version of NPM globally.
* Type `cd reveal.js` and press enter
* Type `npm install` and press enter
* I have made a custom Visual Studio Code task to serve the presentation.
    - Press `ctrl`+`shift`+`p` and type `Tasks: Run Task` and press enter
    - Select `serve VS Code Presentation`
* (Optional) Press `s` to see the speaker notes.

See codeExamples/Program.cs for more instructions to run the C# example
