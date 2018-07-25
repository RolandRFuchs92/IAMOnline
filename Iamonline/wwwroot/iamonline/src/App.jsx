import React from 'react';
import { BS4Text } from './Shared/ShorthandBootstrap.jsx';
import { Form } from 'reactstrap';

export class App extends React.Component {
	render() {
		return (
			<div className="container-fluid">
				<div className="col-lg-4">
					<h4>Checkout this cool little form bru!</h4>

					<Form>
						<BS4Text />
						
					</Form>
				</div>
			</div>
		);
	}
}

