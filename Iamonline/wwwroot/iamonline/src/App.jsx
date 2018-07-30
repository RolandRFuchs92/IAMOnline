import React from 'react';
import { BS4Text } from './Shared/ShorthandBootstrap.jsx';
import { Form } from 'reactstrap';

export class App extends React.Component {
	

	render() {
		const data = { id:"RolandLabel",  name: "Roland", placeholder: "Roland is cool!"};

		return (
			<div className="container-fluid">
				<div className="col-lg-4">
					<h4>Checkout this cool little form bru!</h4>

					<Form>
						<BS4Text data={data}/>
						
					</Form>
				</div>
			</div>
		);
	}
}

