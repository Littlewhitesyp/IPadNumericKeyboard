# IPadNumericKeyboard
Known issue that iPad doesn't have own numeric keyboard. So I made own native keyboard for Xamarin.Forms iOS project 
___
Things that you should do to create custom keyboard:

1)Of course Xamarin.Forms project 
</br>
<p>Entry Keyboard="Numeric"</p>
2)On your page just add Entry with numeric type of keyboard 
</br> </br>
3)Only for iOS project you should create Entry renderer (look on EntryControlRenderer.cs) 
</br> </br>
4)Create .xib file and draw keyboard layout, you could use some icons. Do whatever you want.</br>
(As I'm not xamarin ios developer, it's hard for me to work with Constraints on Visual Studio, so I use Xcode, and create keyboard layout. After that, I add .xib file to visual studio, so it works correctly) 
</br> </br>
5)Bind or add a class to the "view" of your xib file (if it's not exist, please add "view") 
</br> </br>
6)You should add behaviours to generated class for your keyboard (look on iPadNumericKeyboard.cs) 
</br> </br>
7)Add keyboard to your entry renderer if condition below is true (look on EntryControlRenderer.cs) 
</br> </br>
<p>if (e.NewElement.Keyboard == Keyboard.Numeric && Device.Idiom == TargetIdiom.Tablet) </p>

____
# So, if you are not newby in xamarin, after you look on my solution you should easily understand how keyboard makes
