import React from 'react';
import { FormGroup, Label, Input } from 'reactstrap';

export class BS4Text extends React.Component {
	render() {
		return (
			<FormGroup>
				<Label for="username">Username</Label>
				<Input type="text" name="username" id="username" placeholder="Username" />
			</FormGroup>
			);
	}
}