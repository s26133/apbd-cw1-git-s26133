# apbd-cw1-git-s26133
Zadanie 5 - Merge nie był fast-forward, ponieważ w międzyczasie na gałezi main pojawił się nowy commit. Git musiał połączyć dwie niezależne gałezie histori za pomocą merge commita.
# Odpowiedzi na pytania:
**1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?**
Fast-forward: Następuje wtedy, gdy od momentu odgałęzienia naszej nowej gałęzi, na gałęzi docelowej (np. main) nie wprowadzono żadnych nowych zmian. Git nie musi wtedy niczego łączyć, po prostu "przesuwa wskaźnik" do przodu.
Merge commit: Powstaje, gdy na obu gałęziach (bocznej i głównej) pojawiły się niezależne, nowe commity. Ponieważ historie się rozwidliły, Git musi utworzyć nowy, dodatkowy commit, który scali obie ścieżki w jedną.

**2. Czym w praktyce różni się merge od rebase?**
Merge łączy zmiany, zachowując historyczną prawdę o tym, jak przebiegała praca. W logach widać dokładne momenty rozgałęzień i scaleń.
Rebase modyfikuje historię dla większej czytelności. Nie łączy dwóch ścieżek, ale przenosi commity z gałęzi roboczej na sam szczyt gałęzi głównej. Wynikiem jest prosta, liniowa historia, ale commity zostają "przepisane" i otrzymują nowe identyfikatory.

**3. W jaki sposób został rozwiązany konflikt w repozytorium?**
Konflikt wystąpił w pliku Program.cs, ponieważ ta sama linijka kodu (instrukcja Console.WriteLine) została celowo zmodyfikowana na dwóch różnych gałęziach. Git nie wiedział, którą wersję zachować. Rozwiązałem go, otwierając plik w Visual Studio, usuwając znaczniki dodane przez Gita (<<<<<<<, =======, >>>>>>>) i ręcznie edytując kod tak, aby zawierał ostateczną, poprawną treść komunikatu. Po zapisaniu pliku zatwierdziłem to nowym commitem.