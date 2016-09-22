if (Meteor.isClient) {
  // This code is executed on the client only
 
  Meteor.startup(function () {
    // Use Meteor.startup to render the component after the page is ready
    //React.render(<App />, document.getElementById("render-target"));
  });

  var getCurrentPlayerAnimals = function() {
    return [
      { props: ['aa', 'bb'] },
      { props: ['aa'] },
      { props: ['cc', 'dd', 'xx'] },
    ];
  };

  var components = {
    'Animal': Animal,
    'AnimalProperty': AnimalProperty,
    'App': App,
    'FreeCards': FreeCards,
    'Hand': Hand
  };

  FlowRouter.route('/test/:_id', {
    name: 'Lists.show',
    action(params, queryParams) {
      React.render(<App/>, document.getElementById("render-target"));
    }
  });
}