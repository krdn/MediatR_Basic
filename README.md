# MediatR_Basic

https://www.notion.so/krdn/MediatR-516b15e9f7274da1bdfd0a0f52835f83?pvs=4#90a68449397144cba45bcff225dd8893

[The Mediator Pattern In C# .NET – Part 1 – What’s A Mediator?](https://dotnetcoretutorials.com/the-mediator-pattern-in-net-core-part-1-whats-a-mediator/)
[The Mediator Pattern In C# .NET – Part 2 – Roll Your Own](https://dotnetcoretutorials.com/the-mediator-pattern-part-2-roll-your-own/)
[The Mediator Pattern In C# .NET – Part 3 – MediatR Library](https://dotnetcoretutorials.com/the-mediator-pattern-part-3-mediatr-library/)

중재자 패턴의 본질은 "객체 집합이 상호 작용하는 방식을 캡슐화하는 객체를 정의"하는 것입니다. 객체가 서로 명시적으로 참조하는 것을 방지하여 느슨한 결합을 촉진하고 상호 작용을 독립적으로 변경할 수 있습니다.클라이언트 클래스는 중재자를 사용하여 다른 클라이언트에게 메시지를 보낼 수 있고 중재자 클래스의 이벤트를 통해 다른 클라이언트로부터 메시지를 받을 수 있습니다.


- 객체가 상호 작용하는 방식을 캡슐화하는 객체입니다. 따라서 객체 간 "메시지" 전달을 분명히 처리할 수 있습니다.
- 이는 객체가 서로를 참조하지 않고 대신 중재자를 참조함으로써 느슨한 결합을 촉진합니다. 그래서 그들은 메시지를 중재자에게 전달하고 중재자는 이를 올바른 사람에게 전달할 것입니다.




