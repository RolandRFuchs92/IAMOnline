import React from 'react';
import { FormGroup, Label, Input } from 'reactstrap';


export class sidebar_ul extends React.component {

	

	render() {
		function CreateListItem(item) {
			return (
				<li>
					<a href={item.ref}>{item.value}</a>
				</li>);
		}

		function WrapList(resultList) {
			return <ul>{RunList(resultList)}</ul>;
		}

		function RunList(list) {
			let resultList;

			for (let item in list) {
				resultList += CreateListItem(item);
			}
			return WrapList(resultList);
		}

		return (
			<RunList props={this.list}/>
		);
	}
}