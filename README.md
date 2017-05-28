# SpeedBall
Проект по визуелно програмирање, изработен од Даниел Димовски, Емилија Андонова и Ќазим Демиров.
 
SpeedBall е многу едностана игра чија цел е користејќи ги вашите рефлекси и брзина за да добиете што повеќе поени, избегнувајќи правоаголници во различни бои од топката и собирајќи правоаголници во иста боја со топката. Како што ќе освоите повеќе поени и ќе постигнете се повисоко ниво, правоаголниците ќе паѓаат побрзо а играта ќе стане вистиски предизвик.

   ![alt text](https://github.com/DimovskiD/VpProektna/blob/master/SpeedBall/SpeedBall/Resources/StartPage.PNG)
 
На почетниот прозорец (Слика бр. 1) имаме можност да избереме едно од трите копчиња: 


![alt text](https://github.com/DimovskiD/VpProektna/blob/master/SpeedBall/SpeedBall/Resources/start_button_start_01.png) за стартување на самата игра;


 ![alt text](https://github.com/DimovskiD/VpProektna/blob/master/SpeedBall/SpeedBall/Resources/start_button_help.png)за да се запознаете со правилата на играта;
 
 
![alt text](https://github.com/DimovskiD/VpProektna/blob/master/SpeedBall/SpeedBall/Resources/start_button_exit.png)  за излез од играта .


При клик на ![alt text](https://github.com/DimovskiD/VpProektna/blob/master/SpeedBall/SpeedBall/Resources/start_button_start_01.png)                             се одбира едно од четирите ниво на тежина и се внесува име на играчот :

![alt text](https://github.com/DimovskiD/VpProektna/blob/master/SpeedBall/SpeedBall/Resources/diffPage.PNG)

Според нивото се определува и тежината на играта односно секое погорно ниво паѓаат повеќе правоаголници и со поголема брзина.

![alt text](https://github.com/DimovskiD/VpProektna/blob/master/SpeedBall/SpeedBall/Resources/GameEngine.PNG)








Овој поглед е поделен на две сцени, од левата страна се наоѓа сцената за играње додека од десната страна на сцената во долниот десен агол постојат две 
копчиња  ![alt text](https://github.com/DimovskiD/VpProektna/blob/master/SpeedBall/SpeedBall/Resources/start_button_new-game.png)                            за започнување на нова игра  и  ![alt text](https://github.com/DimovskiD/VpProektna/blob/master/SpeedBall/SpeedBall/Resources/start_button_back_v-01.png)                             за да се вратиме
назад на почетното мени, во горниот десен агол се прикажани нивото и поените кои се достигнати, а на средината постои листа од корисници кои се евидентираат со сериализација.



Правила:

Правилата се едноставни со корисетење нa стрека за лево или стрелка за десно го движиме топчето соодветно .

Топчето ја менува својта боја и зависно од неговата боја :

➢ Ги избегнува правоаголниците  со различна боја од топчето.

➢ Ги собира правоаголниците со иста боја со топчето.

➢ Топчето освен што ги избегнува правоаголниците треба да внимава да не ги допре левата и десната црвена граница.


Правоаголниците не само што паѓаат одгоре надолу туку се предвизуваа лево десно (Цик цак) и треперат, меѓутоа како постинуваме се повисоко ниво така правоаголниците паѓаат се побрзо и бобрзо а играта станува се поинтерсна и повозбудлива за играње .



Двете класи class Rectangle и class Ball наследуваат од абстракната класа abstract class Shape.

abstract class Shape

     [Serializable]
     abstract class Shape
    {
       public Point A { get; set; }
       abstract public void Draw(Graphics g);
       abstract public void Move();   
    } 
  
 Class Rectangle 

class Rectangle : Shape

Во оваа класа е овозмозено случајна почетна позиција на правоаголникот и случаен избор на боја со повикување на функцијата ChangeColor која се наоѓа во класата ColorControler каде во истата постои листа со пет бои.

Во оваа класа ги оптоваруваме функциите :
• Draw() 
        public override void Draw(Graphics g)
	     Со оваа функција овозможуваме исцртуване на правоаголниците.
• Move()
	public override void Move()
           Со оваа функција ги придвижуваме правоаголниците од горе па надолу, а со функцијата public void ZigZagMove(bool t) истите ги            движиме лево десно односно цик цак .



 Class Ball
 
 Во оваа класа постојат повеќе функции :
 
 •public void changeColor()
 	која овозможува случајно менување на бојата на топчето и тоа со повикување на функцијата randomColor() која се наоѓа во класата        ColorControler.
	
•public void ChangeDirection(Direction nasoka) 
	овозможува движење на топчето во зависност од тоа која стрелка на тастатурата била притисната.
	
•public Rectangle checkCollisions(Forms f) 
	функција која го враќа правоаголникот со кој настанал судир (ако постои таков) од листата на форми предадени како прв аргумент. 	Ако не настанал судир, враќа Null.
	
•public bool checkLimits(int W) 
	проверува дали топчето ги допрело граничните правоаголници. Ако ги допрело враќа true, инаку враќа false.

Во оваа класа ги оптоваруваме функциите

• Draw() 
	public override void Draw(Graphics g)
	      Со оваа функција овозможуваме исцртуване на топчето.
• Move()
	public override void Move()
              Со оваа функција го придвижуваме топчето лево – десно соодветно на копчето кое е притиснато од страна на играчот.
	      
	     
	     
Class GameEngine

Оваа класа ја содржи главната логика на играта SpeedBall. Се заснова на неколку тајмери кои повикуваат различни функции за промена на боите на правоаголниците и топчето, генерирање на нови правоаголници, проверка на колизии и т.н. 




