Hand = React.createClass({

  renderArray() {
    return this.props.animals.map((animal) => {
      return <Animal props={animal.props} />;
    }); 
  },

  render() {
    return <div className="animals-container">{this.renderArray()}</div>;
  }
});