LA LLAMADA DE MADRUGADA

1. Título
La llamada de las 3:17

2. Premisa
El jugador controla a una persona que está sola en su casa durante la madrugada.
A las 3:17 a. m., recibe una llamada de su propio número de teléfono. Al contestar, escucha su propia voz diciéndole:
"No abras la puerta."
La llamada termina.
Unos segundos después, alguien toca la puerta.
A partir de ese momento, el jugador tendrá que tomar diferentes decisiones para descubrir qué está ocurriendo y tratar de sobrevivir.
La historia tiene un tono de terror con algunos momentos de humor negro y situaciones absurdas.
El conflicto principal es descubrir si la persona que está afuera realmente necesita ayuda o si es algo que está intentando entrar a la casa.
3. Objeto del jugador

El objetivo principal es sobrevivir a la noche y descubrir qué está ocurriendo con la llamada.
Para conseguirlo, el jugador deberá tomar tres decisiones importantes.
Las decisiones pueden cambiar algunos acontecimientos de la historia y determinar qué información recibe el jugador.
Al final existen solamente dos resultados principales:
Final bueno: el personaje consigue sobrevivir.
Final malo: el personaje muere.

4. Mecanicas utilizadas

Para este juego utilizaré cinco mecánicas:

1. Reconocimiento de la intención del jugador / Player Input.
2. Inventario y objetos.
3. Decisiones y rutas narrativas.
4. Condiciones y estados.
5. Finales múltiples.

  + Reconocimiento de la intencion del jugador
    
El jugador podrá elegir acciones mediante opciones numeradas.

Por ejemplo:

«¿Qué quieres hacer?

1. Contestar el teléfono.
2. Ignorar la llamada.»

El jugador escribe el número correspondiente.

El sistema reconoce la opción y continúa la historia dependiendo de la respuesta.

También pueden aparecer acciones como:

«1. Abrir la puerta.
2. Mirar por la ventana.
3. Alejarse de la puerta.»

No será necesario utilizar un sistema complejo que reconozca frases completas. Las opciones estarán predeterminadas para facilitar la programación en C#.

Esta mecánica permite que el jugador tenga control sobre lo que hace el personaje.

  + Inventario y objetos
    
Durante la historia el jugador podrá encontrar algunos objetos que pueden utilizarse posteriormente.

Los objetos serán sencillos para no complicar demasiado el sistema.

Por ejemplo:

- Teléfono.
- Llave de la puerta.
- Linterna.
- Nota encontrada debajo de la puerta.

Los objetos pueden cambiar las posibilidades del jugador.

Por ejemplo, si el jugador encuentra la llave, podrá utilizarla para cerrar una puerta después de entrar en una habitación.

La linterna puede permitirle revisar lugares oscuros y descubrir información.

El inventario no será muy grande. La intención es utilizar los objetos como parte de la historia y no crear un sistema complejo de administración de objetos.

  + Desiciones y rutas narrativas
    
Esta será una de las mecánicas principales del juego.

El jugador tendrá tres decisiones importantes.

Las decisiones no crearán una cantidad enorme de caminos diferentes. En cambio, algunas elecciones harán que el jugador siga una de dos rutas principales.

Ruta 1 — Investigar

El jugador decide investigar lo que está ocurriendo.

Esta ruta permite descubrir más información sobre la llamada y sobre la persona que está afuera.

Ruta 2 — Intentar escapar

El jugador decide no investigar y concentrarse en escapar de la casa.

Esta ruta tiene menos información, pero permite intentar salir antes de que ocurra algo peor.

Las dos rutas tendrán acontecimientos diferentes, pero ambas terminarán llegando a una última decisión.

  + Condiciones y estados

El juego recordará algunas acciones importantes realizadas por el jugador.

No serán muchas variables para mantener el sistema sencillo.

Algunos estados pueden ser:

- "tieneLlave"
- "tieneLinterna"
- "abrioPuerta"
- "investigo"
- "siguioLaVoz"

Por ejemplo:

Si el jugador tiene la linterna:

«Puedes revisar el pasillo oscuro.»

Si no tiene la linterna:

«Está demasiado oscuro para saber qué hay allí.»

Otro ejemplo:

Si el jugador abrió la puerta anteriormente, algunos acontecimientos posteriores serán diferentes.

De esta manera, una decisión anterior puede afectar una situación posterior.

  + Finales multiples
    
El juego tendrá dos finales.

Final A — Sobreviviste

El jugador toma las decisiones que le permiten escapar de la situación.

El personaje consigue salir de la casa y sobrevivir.

Sin embargo, antes de terminar la historia recibe un último mensaje de su propio número:

«"Bien. Esta vez sobreviviste."»

Esto deja un pequeño misterio sobre lo que realmente ocurrió.

Final B — Moriste

El jugador toma una combinación de decisiones que provoca que la criatura o persona que está dentro o fuera de la casa consiga atraparlo.

La pantalla termina con:

«"La llamada terminó."»

FIN.

   
5. Guion y estructura del juego

Inicio

El juego comienza durante la madrugada.

El personaje está solo en su casa.

Son las 3:17 a. m.

Su teléfono comienza a sonar.

El número que aparece en la pantalla es exactamente el mismo número del propio personaje.

El jugador debe decidir si contestar o no.

---

DECISIÓN 1 — La llamada

«El teléfono no deja de sonar.

¿Qué haces?

1. Contestar.
2. Ignorar la llamada.»

Si el jugador contesta:

Escucha su propia voz.

«"No abras la puerta."»

El personaje pregunta quién está hablando.

La voz responde:

«"Soy tú."»

La llamada termina.

Inmediatamente después, alguien toca la puerta.

Esta decisión activa principalmente la ruta de investigación.

---

Si el jugador ignora la llamada:

El teléfono deja de sonar.

Durante unos segundos todo queda en silencio.

Entonces alguien toca la puerta.

El personaje recibe un mensaje:

«"Si escuchas tu propia voz, no abras."»

Esta decisión activa principalmente la ruta de escape.

---

DECISIÓN 2

Dependiendo de la primera decisión, el jugador tendrá que reaccionar ante lo que está ocurriendo.

Ruta de investigación

El personaje escucha golpes en la puerta.

Puede:

1. Mirar por la ventana.
2. Revisar la casa.

Si mira por la ventana:

No hay nadie frente a la puerta.

Sin embargo, puede ver una silueta al otro lado de la calle.

La silueta levanta la cabeza y mira directamente hacia la ventana.

El personaje se aleja.

Entonces escucha un ruido dentro de la casa.

---

Si revisa la casa:

Encuentra una nota debajo de una puerta.

La nota dice:

«"No confíes en la persona que está contigo."»

El personaje está completamente solo.

Esto aumenta el misterio y deja una pista para la decisión final.

---

Ruta de escape

El personaje decide que lo mejor es salir de la casa.

Puede:

1. Salir por la puerta principal.
2. Buscar otra salida.

Si intenta salir por la puerta principal:

Los golpes se detienen.

La puerta está abierta.

Eso parece demasiado fácil.

Antes de salir, el teléfono vuelve a sonar.

---

Si busca otra salida:

Encuentra una ventana que puede utilizar para escapar.

Sin embargo, necesita la llave que está en otra habitación para abrir una puerta que bloquea el camino.

Esto hace que el objeto encontrado durante la partida tenga una función.

---

DECISIÓN 3 — La última decisión

Después de los acontecimientos anteriores, el personaje descubre que algo está ocurriendo dentro de la casa.

El teléfono vuelve a sonar.

La voz dice:

«"No salgas."»

Después se escucha otra voz desde el pasillo:

«"No escuches al teléfono."»

El jugador debe decidir a quién creer.

Opción 1 — Seguir las instrucciones del teléfono.

Opción 2 — Ignorar la llamada y escapar.

Esta es la última decisión importante del juego.

Dependiendo de las decisiones anteriores y de algunos estados del juego, esta decisión puede llevar al jugador al final bueno o al final malo.

6. Estados del juego

El programa necesitará recordar principalmente:

"tieneLlave"

Indica si el jugador encontró la llave.

- "true" = tiene la llave.
- "false" = no la tiene.

Se utiliza para determinar si puede abrir determinadas puertas.

---

"tieneLinterna"

Indica si el jugador encontró la linterna.

- "true" = puede revisar lugares oscuros.
- "false" = no puede ver determinadas cosas.

---

"investigo"

Indica si el jugador decidió investigar lo que estaba ocurriendo.

- "true" = siguió la ruta de investigación.
- "false" = intentó escapar.

---

"abrioPuerta"

Indica si el jugador abrió la puerta principal.

Esta información puede cambiar acontecimientos posteriores.

---

"siguioLaVoz"

Indica qué decidió hacer el jugador durante la última decisión.

Esta variable ayuda a determinar el resultado final.

7. Estructura general

Aunque existen diferentes decisiones, el juego no tendrá una cantidad infinita de caminos.

Las rutas se separan temporalmente y después vuelven a encontrarse antes de la decisión final.

8. Finales posibles
   
Final A — Sobreviviste

El jugador consigue escapar de la casa.

La calle está completamente vacía.

El personaje corre hasta encontrar un lugar seguro.

Cuando finalmente revisa su teléfono, aparece un último mensaje:

«"Bien. Esta vez sobreviviste."»

El personaje mira la hora.

Son las 3:17 a. m.

FIN.

---

Final B — Moriste

El jugador toma las decisiones equivocadas y termina atrapado.

El teléfono deja de sonar.

La casa queda completamente en silencio.

Entonces escucha su propia voz detrás de él:

«"Te dije que no abrieras."»

La pantalla queda en negro.

FIN.

9. Relacion entre las mecanicas
    
Las mecanicas funcionas juntas.
Las desiciones determinan que ruta narrativa sigue, Los objetos del inventario pueden permitir o impedir determinadas acciones.

Los estados permiten que el juego recuerde decisiones anteriores.

Finalmente, las condiciones y decisiones acumuladas determinan uno de los dos finales posibles.

Por ejemplo:

El jugador decide investigar
        ↓
investigo = true
        ↓
Encuentra una pista
        ↓
Obtiene la llave
        ↓
tieneLlave = true
        ↓
Puede abrir una salida
        ↓
Toma la decisión final
        ↓
Sobrevive

De esta manera, el juego no solamente cuenta una historia: las decisiones del jugador modifican el estado de la partida y ese estado afecta lo que puede ocurrir posteriormente.
