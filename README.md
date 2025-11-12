# CyberHuman
Projeto acadêmico da graduação de Engenharia de Software

# CyberHuman - Aplicação WPF
Este projeto foi desenvolvido com o intuito de ser usado como aplicação para recapacitação de profissionais cujas profissões vem sendo duramente substituídas por IA, em uma tentativa de recapacitá-los para o ambiente profissional e preparar tanto as empresas, quanto os funcionários, para o futuro é que este projeto foi desenvolvido. No entanto, essa não é uma aplicação completa devido ao prazo de 8 dias para a conclusão de 8 projetos diferentes, então as principais funcionalidades foram priorizados para fins demonstrativos de que sabemos e podemos fazer.

# Tecnologias Utilizadas

- .NET 8 / WPF
- C#
- XAML
- MVVM
- Estilos personaliados e gradientes modernos
- Cores inspiradas em projetos de Tailwind

# Objetivo
Este trabalho tem como objetivo demonstrar conhecimentos e aplicação de conceitos de:

- Orientação a Objetos
- Manipulação de Janelas e Eventos
- Navegação dinâmica (views)
- Encapsulamento de telas (DashBoard, CourseDetails, WelcomeScreens e etc)
- Herança e Polimorfismo

## Estrutura do Projeto
```
CyberHuman/
├── App.xaml -> Seta estilos de cores, botões e estilo dos cards
├── App.xaml.cs -> Lógica para ler os estilos de cores, botões e cards
├── MainWindow.xaml -> janela principal
├── MainWindow.xaml.cs -> Lógica da janela principal e da pré visualização.
├── Models/ 
│   └── Class1.cs -> Responsável pelos modelos de Dados 
└── Views/
    ├── WelcomeScreen.xaml -> Tela inicial
    ├── WelcomeScreen.xaml.cs -> Lógica da tela inicial
    ├── Dashboard.xaml -> Tela com lista de cursos
    ├── Dashboard.xaml.cs -> Lógica da tela com a lista de cursos
    ├── CourseDetails.xaml -> Tela com detalhes do curso selecionado
    └── CourseDetails.xaml.cs -> Lógica da tela com detalhes dos cursos selecionados
```

# Componentes

- MainWindow: Gerencia a janela principal e trocar de telas.
    - Chama a janela de boas vindas.
    - Chama DashBoard.
    - Chama CourseDetails.
    - Permite minimar e fechar a tela através das funções CloseWindow e MinimizeWindow.
    - Utiliza evento de arrastar a janela com MouseLeftButtonDown.
    - Utiliza OnBack e OnCourseSelected pra controlar navegação.

- Dashboard: Apresenta a lista de cursos disponíveis.
    - Dispara OnCourseSelected quando usuário escolhe um curso.
    - Possui as configurações e estilazação do conteúdo, ícones, lista de cursos e header.

- CourseDetails: Mostra as informações compeltas do curso selecionado.
    - Possui botão de voltar (evento OnBack).
    - Possui as configurações e estilazação do seu conteúdo, descrição, cards, duração, nível, formato e módulos.
    - Possui um espaço para a adição de módulos no futuro.

- Course: Classe modelo que representa um curso e suas propriedades.

------------------------------------------------------------------------

# Funcionalidades e Interação:

Arrastar Janela -> Clicar e segurar com o mouse -> MouseLeftButtonDown ||
Minimizar -> Botão de Minimizar -> MinimizeWindow() ||
Fechar -> Botão fechar -> CloseWindow() ||
Trocar de tela -> Eventos customizados -> OnBack, OnStart e OnCourseSelected


# Conceitos de POO que foram aplicados:

Herança -> MainWindow : Window (entre outros....) ||
Encapsulamento -> Cada tela tem classes próprias e lógica isolada ||
Polimorfismo -> Manipulação de eventos genéricos (OnBack, OnStart) ||
Abstração -> O usuário não precisa saber o que cada tela faz internamente

