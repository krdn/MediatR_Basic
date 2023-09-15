# MediatR_Basic

https://www.notion.so/krdn/MediatR-516b15e9f7274da1bdfd0a0f52835f83?pvs=4#90a68449397144cba45bcff225dd8893

아래의 강좌의 코드를 기반으로 제작되었습니다.

[The Mediator Pattern In C# .NET – Part 1 – What’s A Mediator?](https://dotnetcoretutorials.com/the-mediator-pattern-in-net-core-part-1-whats-a-mediator/)

Mediator 패턴을 사용하지 않은 예시, Mediator패선을 사용한 예시

[The Mediator Pattern In C# .NET – Part 2 – Roll Your Own](https://dotnetcoretutorials.com/the-mediator-pattern-part-2-roll-your-own/)

“IEnumerable” Pattern을 사용하여 Madiator패턴 직접 구현, 필터를 사용한 예시

[The Mediator Pattern In C# .NET – Part 3 – MediatR Library](https://dotnetcoretutorials.com/the-mediator-pattern-part-3-mediatr-library/)

MediatR 확장프로그램을 사용하여 구현한 


중재자 패턴의 본질은 "객체 집합이 상호 작용하는 방식을 캡슐화하는 객체를 정의"하는 것입니다. 객체가 서로 명시적으로 참조하는 것을 방지하여 느슨한 결합을 촉진하고 상호 작용을 독립적으로 변경할 수 있습니다.클라이언트 클래스는 중재자를 사용하여 다른 클라이언트에게 메시지를 보낼 수 있고 중재자 클래스의 이벤트를 통해 다른 클라이언트로부터 메시지를 받을 수 있습니다.


- 객체가 상호 작용하는 방식을 캡슐화하는 객체입니다. 따라서 객체 간 "메시지" 전달을 분명히 처리할 수 있습니다.
- 이는 객체가 서로를 참조하지 않고 대신 중재자를 참조함으로써 느슨한 결합을 촉진합니다. 그래서 그들은 메시지를 중재자에게 전달하고 중재자는 이를 올바른 사람에게 전달할 것입니다.




