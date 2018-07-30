import React from 'react';
import { FormGroup, Label, Input } from 'reactstrap';

export class BS4Text extends React.Component {
	render() {
		return (
			<FormGroup>
				<Label for={this.props.data.id}>{this.props.data.name}</Label>
				<Input type="text" name={this.props.data.id} id={this.props.data.id} placeholder={this.props.data.placeholder} />
			</FormGroup>
			);
	}
}