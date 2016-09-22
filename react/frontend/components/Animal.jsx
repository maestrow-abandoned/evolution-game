Animal = React.createClass({
  
  renderProps() {
    return this.props.props.map((prop) => {
      return <AnimalProperty name={prop} />;
    });
  },

  render() {
    return <div className="animal">{this.renderProps()}</div>;
  }
});
