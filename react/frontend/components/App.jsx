// App component - represents the whole app
App = React.createClass({
 

  getCurrentPlayerAnimals() {
    return [
      { props: ['aa', 'bb'] },
      { props: ['aa'] },
      { props: ['cc', 'dd', 'xx'] },
    ];
  },

  render() {
    return (
      <div id="container">
        <div id="left-panel">
          <div id="players">
            <ul>
              <li>player 1</li>
              <li>player 2</li>
            </ul>
          </div>
          <div id="events">
            <ul>
              <li>event1</li>
              <li>event2</li>
            </ul>
          </div>
        </div>
        <div id="center-panel">
          <div id="table">
            Карты игроков
          </div>
          <div id="game-state">
            Состояние игры
          </div>
          <Hand animals={this.getCurrentPlayerAnimals()} />
          <div id="free-cards">
            Закрытые карты текущего игрока
          </div>
        </div>
      </div>
    );
  }
});