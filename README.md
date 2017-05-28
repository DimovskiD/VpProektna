# SpeedBall
 Проект по визуелно програмирање, изработен од Даниел Димовски, Емилија Андонова и Ќазим Демиров.

## Опис на апликацијата 
 
SpeedBall е многу едностана игра чија цел е користејќи ги вашите рефлекси и брзина за да добиете што повеќе поени, избегнувајќи правоаголници во различни бои од топката и собирајќи правоаголници во иста боја со топката. Како што ќе освоите повеќе поени и ќе постигнете се повисоко ниво, правоаголниците ќе паѓаат побрзо а играта ќе стане вистиски предизвик.

## Упатство за користење

   ![alt text](https://github.com/DimovskiD/VpProektna/blob/master/SpeedBall/SpeedBall/Resources/StartPage.PNG)
                                          
					         

 
 
На почетниот прозорец  имаме можност да избереме едно од трите копчиња: 


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

Во текот на играта доколку постојат корисници се проверуваат поените на играчот со поените на веќе регистрираните играчи со постигнати поени.Ако се надминене се појавува порака со која се известува играчот со порака "Congrats you passed "+ име на регистрираниот играч.

Откако ќе заврши играта односно топчето ќе се судри со правоаголникот се врши проверка дали постигнатите поени се најдобри.
Доколку е исполнет условот се појавува форма со која се честита на играчот за постигнувањето.

![alt text](https://github.com/DimovskiD/VpProektna/blob/master/SpeedBall/SpeedBall/Resources/best.PNG)


Доколку условот не е исполнет се појавува нова форма, која исто така се појавува и по отварањето на формата за честитки на играчот, и го известува играчот за постигнатите поени и ги прикажува најдобрите 5 регистрирани играчи доколку постојат. 

![alt text](https://github.com/DimovskiD/VpProektna/blob/master/SpeedBall/SpeedBall/Resources/highScorePage.PNG)




#### Правила:

Правилата се едноставни со корисетење нa стрека за лево или стрелка за десно го движиме топчето соодветно .

Топчето ја менува својта боја и зависно од неговата боја :

➢ Ги избегнува правоаголниците  со различна боја од топчето.

➢ Ги собира правоаголниците со иста боја со топчето.

➢ Топчето освен што ги избегнува правоаголниците треба да внимава да не ги допре левата и десната црвена граница.

Правоаголниците не само што паѓаат одгоре надолу туку се предвизуваа лево десно (Цик цак) и треперат, меѓутоа како постинуваме се повисоко ниво така правоаголниците паѓаат се побрзо и бобрзо а играта станува се поинтерсна и повозбудлива за играње .




## Решение на проблемот

Двете класи class Rectangle и class Ball наследуваат од абстракната класа abstract class Shape.

### abstract class Shape

     [Serializable]
     abstract class Shape
    {
       public Point A { get; set; }
       abstract public void Draw(Graphics g);
       abstract public void Move();   
    } 
  
 ### Class Rectangle 

     class Rectangle : Shape

Во оваа класа е овозмозено случајна почетна позиција на правоаголникот и случаен избор на боја со повикување на функцијата ChangeColor која се наоѓа во класата ColorControler каде во истата постои листа со пет бои.

Во оваа класа ги оптоваруваме функциите :

• Draw() 

        public override void Draw(Graphics g)
Со оваа функција овозможуваме исцртуване на правоаголниците.

• Move()

	public override void Move()
Со оваа функција ги придвижуваме правоаголниците од горе па надолу, а со функцијата public void ZigZagMove(bool t) истите ги движиме лево десно односно цик цак.



 ### Class Ball
 
      class Ball : Shape
 
 Во оваа класа постојат повеќе функции :
 
 •public void changeColor()
 	која овозможува случајно менување на бојата на топчето и тоа со повикување на функцијата randomColor() која се наоѓа во класата         ColorControler.
	
•public void ChangeDirection(Direction nasoka) 
	овозможува движење на топчето во зависност од тоа која стрелка на тастатурата била притисната.
	
•public Rectangle checkCollisions(Forms f) 
	функција која го враќа правоаголникот со кој настанал судир (ако постои таков) од листата на форми предадени како прв аргумент. 	Ако не настанал судир, враќа Null.
	
•public bool checkLimits(int W) 
	проверува дали топчето ги допрело граничните правоаголници. Ако ги допрело враќа true, инаку враќа false.

Во оваа класа ги оптоваруваме функциите:
                                               
• Draw() 

	public override void Draw(Graphics g) 
Со оваа функција овозможуваме исцртуване на топчето.

• Move()

	 public override void Move()
   Со оваа функција го придвижуваме топчето лево – десно соодветно на копчето кое е притиснато од страна на играчот.
	      
	     
	     
### Class GameEngine

Оваа класа ја содржи главната логика на играта SpeedBall. Се заснова на неколку тајмери кои повикуваат различни функции за промена на боите на правоаголниците и топчето, генерирање на нови правоаголници, проверка на колизии и т.н. 

#### Функција ZigZag_tick :

    void ZigZag_tick(object sender,EventArgs e)
        {
            forms.CheckLimit();
            if (t)
            {
                
                forms.ZigZagMove(t);
                t = false;
            }
            else
            {
                forms.ZigZagMove(t);
                t = true;
            }
        }
Оваа функција овозможува придвижување на правоаголниците лево десно, со помош на функцијата CheckLimit() која се наоѓа во класата Rectangle проверува дали случајно избраниот правоаголник е во дозволена област и ако е ја поставува променливата zigzag на true. 
Со повикување на функцијата ZigZagMove(t) која се наоѓа во класата Forms и проверува дали  zigzag e еднаква true, и доколку е прима булеан вредност според која соодветно false= лево true= десно.

### Сериализација

За да ја овозможиме сериализацијата постои класа class UsersScene во која се чува листа од Class User која содржи име на играчот и постигнати поени.

                                     public List<User> lista { get; set; }

                                     

      



